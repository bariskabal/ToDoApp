using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ToDoApp.Business.Interfaces;
using ToDoApp.DTO.DTOs.BildirimDtos;
using ToDoApp.Entities.Concrete;
using ToDoApp.webUI.BaseControllers;
using ToDoApp.webUI.StringInfo;

namespace ToDoApp.webUI.Areas.Member.Controllers
{
    [Authorize(Roles=RoleInfo.Member)]
    [Area(AreaInfo.Member)]
    public class BildirimController : BaseIdentityController
    {

        private readonly IBildirimService _bildirimService;
        private readonly IMapper _mapper;
        public BildirimController(IMapper mapper,IBildirimService bildirimService,UserManager<AppUser> userManager):base(userManager)
        {
            _mapper=mapper;
            _bildirimService=bildirimService;
        }
        public async Task<IActionResult> Index()
        {
            TempData["Active"]=TempDataInfo.Bildirim;
            var user = await GetirGirisYapanKullanici();
            return View(_mapper.Map<List<BildirimListDto>>(_bildirimService.GetirOkunmayanlar(user.Id)));
        }

        [HttpPost]
        public IActionResult Index(int id)
        {
            var guncellenecekBildirim = _bildirimService.GetirIdile(id);
            guncellenecekBildirim.Durum = true;
            _bildirimService.Guncelle( guncellenecekBildirim);
            return RedirectToAction("Index");
        }
    }
}