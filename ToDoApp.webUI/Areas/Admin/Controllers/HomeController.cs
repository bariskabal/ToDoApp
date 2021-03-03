using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ToDoApp.Business.Interfaces;
using ToDoApp.DTO.DTOs.GorevDtos;
using ToDoApp.Entities.Concrete;
using ToDoApp.webUI.BaseControllers;
using ToDoApp.webUI.StringInfo;

namespace ToDoApp.webUI.Areas.Admin.Controllers
{
    [Authorize(Roles=RoleInfo.Admin)]
    [Area(AreaInfo.Admin)]
    public class HomeController : BaseIdentityController
    {
        
        private readonly IGorevService _gorevService;
        private readonly IBildirimService _bildirimService;
        private readonly IRaporService _raporService;
        public HomeController(IGorevService gorevService,IRaporService raporService,UserManager<AppUser> userManager,IBildirimService bildirimService): base(userManager)
        {
            _gorevService=gorevService;
            _bildirimService=bildirimService;
            _raporService=raporService;
        }
        public async Task<IActionResult> Index()
        {
            var user = await GetirGirisYapanKullanici();
            ViewBag.YazilmişRaporSayisi = _raporService.GetirRaporSayisi();
            ViewBag.OkunmayanBildirimler = _bildirimService.GetirOkunmayanSayisiAppUserId(user.Id);
            ViewBag.AtanmayiBekleyenGörevSayisi = _gorevService.GetirAtanmayıBekleyenGörevSayisi();
            ViewBag.TamamlanmisGorevSayisi=_gorevService.GetirTamamlanmısGorev();
            
            TempData["Active"]=TempDataInfo.AnaSayfa;
            return View();
        }
        public IActionResult TamamlanmısGorevListe()
        {
            
            var gorevListe = _gorevService.TamamlanmısGorevGetirListe();
            List<GorevListAllDto> models = new List<GorevListAllDto>();

            foreach (var item in gorevListe)
            {
                GorevListAllDto model = new GorevListAllDto();
                model.Ad=item.Ad;
                model.Aciklama=item.Aciklama;
                
                
                models.Add(model);
            }
            
            return View(models);
        }
    }
}