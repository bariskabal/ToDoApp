using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ToDoApp.Business.Interfaces;
using ToDoApp.DTO.DTOs.GorevDtos;
using ToDoApp.DTO.DTOs.RaporDtos;
using ToDoApp.Entities.Concrete;
using ToDoApp.webUI.BaseControllers;
using ToDoApp.webUI.StringInfo;

namespace ToDoApp.webUI.Areas.Member.Controllers
{
    [Authorize(Roles=RoleInfo.Member)]
    [Area(AreaInfo.Member)]
    public class IsEmriController : BaseIdentityController
    {
        private readonly IBildirimService _bildirimService;
        private readonly IRaporService _raporService;

        private readonly IGorevService _gorevService;
        private readonly IMapper _mapper;
        public IsEmriController(IMapper mapper,IGorevService gorevService,IBildirimService bildirimService,UserManager<AppUser> userManager,IRaporService raporService):base(userManager)
        {
            _bildirimService=bildirimService;
            _raporService=raporService;
            _gorevService=gorevService;
            _mapper=mapper;
        }
        public async Task<IActionResult> Index()
        {
            TempData["Active"]=TempDataInfo.IsEmri;
            var user = await GetirGirisYapanKullanici();

            return View(_mapper.Map<List<GorevListAllDto>>(_gorevService.GetirTumTablolarla(I=>I.AppUserId == user.Id && !I.Durum)));
        }
        public IActionResult EkleRapor(int id)
        {
            TempData["Active"]=TempDataInfo.IsEmri;
            var gorev = _gorevService.GetirAciliyetIdile(id);

            RaporAddDto model = new RaporAddDto();
            model.GorevId=id;
            model.Gorev=gorev;
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> EkleRapor(RaporAddDto model)
        {
            if (ModelState.IsValid)
            {
                _raporService.Kaydet(new Rapor(){
                    GorevId=model.GorevId,
                    Detay=model.Detay,
                    Tanim=model.Tanim
                });
                
                var adminUserList = await _userManager.GetUsersInRoleAsync("Admin");
                var aktifKullanici = await GetirGirisYapanKullanici();
                foreach (var item in adminUserList)
                {
                    _bildirimService.Kaydet(new Bildirim{
                        Aciklama=$"{aktifKullanici.Name} {aktifKullanici.SurName} yeni bir rapor yazdı",
                        AppUserId=item.Id,
                    });
                }

                return RedirectToAction("Index"); 
            }
            return View(model);
        }
        public IActionResult GuncelleRapor(int id)
        {
            TempData["Active"]=TempDataInfo.IsEmri;
            return View(_mapper.Map<RaporUpdateDto>(_raporService.GetirGorevileId(id)));
        }
        [HttpPost]
        public IActionResult GuncelleRapor(RaporUpdateDto model)
        {
            if (ModelState.IsValid)
            {
                var guncellenecekRapor =  _raporService.GetirIdile(model.Id);
                guncellenecekRapor.Tanim=model.Tanim;
                guncellenecekRapor.Detay=model.Detay;

                _raporService.Guncelle(guncellenecekRapor);
                return RedirectToAction("Index");
            }
            return View(model);
            
        }
        public async Task<IActionResult> TamamlaGorev(int gorevId)
        {
            var guncellenecekGorev =  _gorevService.GetirIdile(gorevId);
            guncellenecekGorev.Durum=true;
            _gorevService.Guncelle(guncellenecekGorev);

            var adminUserList = await _userManager.GetUsersInRoleAsync("Admin");
                var aktifKullanici = await GetirGirisYapanKullanici();
                foreach (var item in adminUserList)
                {
                    _bildirimService.Kaydet(new Bildirim{
                        Aciklama=$"{aktifKullanici.Name} {aktifKullanici.SurName} vermiş oldugunuz bir görevi tamamladı",
                        AppUserId=item.Id,
                    });
                }
            return Json(null);
        }
    }
}