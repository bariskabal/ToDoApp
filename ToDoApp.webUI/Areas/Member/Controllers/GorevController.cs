using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ToDoApp.Business.Concrete;
using ToDoApp.Business.Interfaces;
using ToDoApp.DTO.DTOs.GorevDtos;
using ToDoApp.Entities.Concrete;
using ToDoApp.webUI.BaseControllers;
using ToDoApp.webUI.StringInfo;

namespace ToDoApp.webUI.Areas.Member.Controllers
{
    [Authorize(Roles=RoleInfo.Member)]
    [Area(AreaInfo.Member)]
    public class GorevController : BaseIdentityController
    {

        private readonly IGorevService _gorevService;
        private readonly IMapper _mapper;
        public GorevController(IMapper mapper,IGorevService gorevService,UserManager<AppUser> userManager):base(userManager)
        {
            _gorevService = gorevService;
            _mapper=mapper;
        }
        public async Task<IActionResult> Index(int aktifSayfa=1)
        {
            TempData["Active"]=TempDataInfo.Gorev;
            var user = await GetirGirisYapanKullanici();
            int toplamSayfa;

            var gorevler = _mapper.Map<List<GorevListAllDto>>(_gorevService.GetirTumTablolarlaTamamlanmayan(out toplamSayfa,user.Id,aktifSayfa));

            
            ViewBag.ToplamSayfa =toplamSayfa;
            ViewBag.AktifSayfa = aktifSayfa;
            
            return View(gorevler);
        }
    }
}