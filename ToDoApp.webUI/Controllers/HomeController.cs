using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ToDoApp.Business.Interfaces;
using ToDoApp.DTO.DTOs.AppUserDtos;
using ToDoApp.Entities.Concrete;
using ToDoApp.webUI.BaseControllers;
using ToDoApp.webUI.Models;


namespace ToDoApp.webUI.Controllers
{
    public class HomeController : BaseIdentityController
    {
        private readonly IGorevService _gorevService;
        private readonly SignInManager<AppUser> _signInManager;

        public HomeController(IGorevService gorevService,UserManager<AppUser> userManager,SignInManager<AppUser> signInManager):base(userManager)
        {
            _gorevService = gorevService;
            _signInManager = signInManager;
        }

        public IActionResult Index()
        {
            
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> GirisYap(AppUserSignInDto model)
        {
            if (ModelState.IsValid)
            {
                var user =  await _userManager.FindByNameAsync(model.UserName);
                if (user!=null)
                {
                    var identityResult = await _signInManager.PasswordSignInAsync(model.UserName,model.Password,model.RememberMe,false);
                
                    if (identityResult.Succeeded)
                    {
                        var roller =  await _userManager.GetRolesAsync(user);  
                        
                        if (roller.Contains("Admin"))
                        {
                            return RedirectToAction("Index","Home",new {area="Admin"});
                        }
                        else{
                             return RedirectToAction("Index","Home",new {area="Member"});   
                        }
                    }

                
                }
                ModelState.AddModelError("","Kullanıcı adı veya şifre hatalı");
            }
            return View("Index",model);
        }
 
        public IActionResult KayitOl()
        {
           return View();
        }
        [HttpPost]
        public async  Task<IActionResult> KayitOl(AppUserAddDto model)
        {
            if (ModelState.IsValid)
            {
                AppUser user = new AppUser()
                {
                    UserName=model.UserName,
                    Email=model.Email,
                    Name=model.Name,
                    SurName=model.SurName
                };


                var result =  await _userManager.CreateAsync(user,model.Password);

                if (result.Succeeded)
                {
                    var roleResult  = await _userManager.AddToRoleAsync(user,"Member");
                    if (roleResult.Succeeded)
                    {
                        return RedirectToAction("Index");
                    }
                    HataEkle(roleResult.Errors);
                }
                HataEkle(result.Errors);
            }
            return View(model);
        }
        public async Task<IActionResult> CikisYap()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index");
        }
        public IActionResult StatusCode(int? code)
        {
            if (code == 404)
            {
                ViewBag.Code=code;
                ViewBag.Message="Sayfa bulunamadı";
            }
            return View();
        }
        public IActionResult Error()
        {
            var exceptionHandler = HttpContext.Features.Get<IExceptionHandlerPathFeature>();
           
            return View();
        }
        public void Hata()
        {
            throw new Exception("Hata");
        }
    }
}
