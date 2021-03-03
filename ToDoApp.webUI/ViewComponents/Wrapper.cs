using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ToDoApp.Business.Interfaces;
using ToDoApp.DTO.DTOs.AppUserDtos;
using ToDoApp.Entities.Concrete;

namespace ToDoApp.webUI.ViewComponents
{
    public class Wrapper : ViewComponent
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IBildirimService _bildirimService;
        private readonly IMapper _mapper;
        public Wrapper(IMapper mapper,UserManager<AppUser> userManager,IBildirimService bildirimService)
        {
            _userManager = userManager;
            _bildirimService=bildirimService;
            _mapper=mapper;
        }
        public IViewComponentResult Invoke()
        {
            var identityUser = _userManager.FindByNameAsync(User.Identity.Name).Result;
            var model = _mapper.Map<AppUserListDto>(_userManager.FindByNameAsync(User.Identity.Name).Result);

            var bildirimler = _bildirimService.GetirOkunmayanlar(model.Id).Count;
            ViewBag.BildirimSayisi =bildirimler;


            var roles = _userManager.GetRolesAsync(identityUser).Result;
            if (roles.Contains("Admin"))
            {
                return View(model);
            }
            return View("Member",model);
        }
    }
}