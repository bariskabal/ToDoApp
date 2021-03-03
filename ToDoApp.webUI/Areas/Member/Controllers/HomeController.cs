using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ToDoApp.Business.Concrete;
using ToDoApp.Business.Interfaces;
using ToDoApp.Entities.Concrete;
using ToDoApp.webUI.BaseControllers;
using ToDoApp.webUI.StringInfo;

namespace ToDoApp.webUI.Areas.Member.Controllers
{
    [Authorize(Roles=RoleInfo.Member)]
    [Area(AreaInfo.Member)]
    public class HomeController : BaseIdentityController
    {
        private readonly IBildirimService _bildirimService;
        private readonly IRaporService _raporService;
        private readonly IGorevService _gorevService;

        public HomeController(IRaporService raporService,IBildirimService bildirimService,UserManager<AppUser> userManager,IGorevService gorevService):base(userManager)
        {
            _raporService=raporService;
            _gorevService=gorevService;
            _bildirimService=bildirimService;
        }
        public async Task<IActionResult> Index()
        {
            TempData["Active"]=TempDataInfo.AnaSayfa;
            var user = await GetirGirisYapanKullanici();
            ViewBag.RaporSayisi = _raporService.GetirRaporSayisiileAppUserId(user.Id);

            ViewBag.TamamlananGorevSayisi =_gorevService.GetirGorevSayisiTamamlananileAppUserId(user.Id);
            
            ViewBag.TamamlanmasiGerekenGorevSayisi = _gorevService.GetirGorevSayisiTamamlanmasıGerekenAppUserId(user.Id);

            ViewBag.OkunmayanBildirimSayisi = _bildirimService.GetirOkunmayanSayisiAppUserId(user.Id);


            return View();
        }        
    }
}