using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ToDoApp.Business.Concrete;
using ToDoApp.Business.Interfaces;
using ToDoApp.DTO.DTOs.AppUserDtos;
using ToDoApp.DTO.DTOs.GorevDtos;
using ToDoApp.DTO.DTOs.RaporDtos;
using ToDoApp.Entities.Concrete;
using ToDoApp.webUI.BaseControllers;
using ToDoApp.webUI.StringInfo;

namespace ToDoApp.webUI.Areas.Admin.Controllers
{
    [Authorize(Roles=RoleInfo.Admin)]
    [Area(AreaInfo.Admin)]
    public class IsEmriController : BaseIdentityController
    {
        private readonly IAppUserService _appUserService;
        private readonly IGorevService _gorevService;
        private readonly IDosyaService _dosyaServices;
        private readonly IBildirimService _bildirimService;
        private readonly IMapper _mapper;
        public IsEmriController(IMapper mapper,IAppUserService appUserService,IBildirimService bildirimService,IGorevService gorevService,UserManager<AppUser> userManager,IDosyaService dosyaServices):base(userManager)
        {
            _appUserService=appUserService;
            _gorevService=gorevService;
            _dosyaServices=dosyaServices;
            _bildirimService=bildirimService;
            _mapper=mapper;
        }
        public IActionResult Index()
        {
            TempData["Active"]=TempDataInfo.IsEmri;
            return View(_mapper.Map<List<GorevListAllDto>>(_gorevService.GetirTumTablolarla()));
        }
        public IActionResult AtaPersonel(int id,string s,int sayfa=1)
        {
            TempData["Active"]=TempDataInfo.IsEmri;
            ViewBag.AktifSayfa=sayfa;
            // ViewBag.ToplamSayfa =(int)Math.Ceiling((double)_appUserService.GetirAdminOlmayanlar().Count/3);
            
            ViewBag.Aranan=s;


            int toplamSayfa;
             

            var personeller = _mapper.Map<List<AppUserListDto>>(_appUserService.GetirAdminOlmayanlar(out toplamSayfa,s,sayfa));

            ViewBag.ToplamSayfa=toplamSayfa;
            
            ViewBag.Personeller = personeller;

             return View( _mapper.Map<GorevListDto>(_gorevService.GetirAciliyetIdile(id)));
            
        }
        [HttpPost]
        public IActionResult AtaPersonel(PersonelGorevlendirDto model)
        {
            TempData["Active"]=TempDataInfo.IsEmri;
            var guncellenecekGorev = _gorevService.GetirIdile(model.GorevId);
            guncellenecekGorev.AppUserId = model.PersonelId;
            _gorevService.Guncelle(guncellenecekGorev);

            _bildirimService.Kaydet(new Bildirim{
                AppUserId=model.PersonelId,
                Aciklama=$"{guncellenecekGorev.Ad} adlı iş için görevlendirildiniz."
            });

            return RedirectToAction("Index");
        }
        public IActionResult GorevlendirPersonel(PersonelGorevlendirDto model)
        {
            TempData["Active"]=TempDataInfo.IsEmri;

            PersonelGorevlendirListDto personelGorevlendirModel = new PersonelGorevlendirListDto();
            personelGorevlendirModel.AppUser = _mapper.Map<AppUserListDto>(_userManager.Users.FirstOrDefault(I=>I.Id == model.PersonelId));
            personelGorevlendirModel.Gorev = _mapper.Map<GorevListDto>(_gorevService.GetirAciliyetIdile(model.GorevId));
   
            return View(personelGorevlendirModel);
        } 
        public IActionResult Detaylandir(int Id)
        {
            TempData["Active"]=TempDataInfo.IsEmri;
            return View(_mapper.Map<GorevListAllDto>(_gorevService.GetirRaporlarileId(Id)));
        }
        public IActionResult GetirExcel(int Id)
        {
        
            return File(_dosyaServices.AktarExcel(_mapper.Map<List<RaporDosyaDto>>(_gorevService.GetirRaporlarileId(Id).Raporlar)),"application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",Guid.NewGuid()+".xlsx");
        }
        public IActionResult GetirPdf(int Id)
        {
            var path = _dosyaServices.AktarPdf(_mapper.Map<List<RaporDosyaDto>>(_gorevService.GetirRaporlarileId(Id).Raporlar));
            return File(path,"application/pdf",Guid.NewGuid()+".pdf");
        }
        
    }
}