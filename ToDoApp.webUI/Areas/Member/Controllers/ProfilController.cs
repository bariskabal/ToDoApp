using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ToDoApp.DTO.DTOs.AppUserDtos;
using ToDoApp.Entities.Concrete;
using ToDoApp.webUI.BaseControllers;
using ToDoApp.webUI.StringInfo;

namespace ToDoApp.webUI.Areas.Member.Controllers
{
    [Authorize(Roles=RoleInfo.Member)]
    [Area(AreaInfo.Member)]
    public class ProfilController : BaseIdentityController
    {

        private readonly IMapper _mapper;
        public ProfilController(IMapper mapper,UserManager<AppUser> userManager):base(userManager)
        {

            _mapper=mapper;
        }

        public async Task<IActionResult> Index()
        {
            TempData["Active"]=TempDataInfo.Profil;
            var user = await GetirGirisYapanKullanici();
            return View(_mapper.Map<AppUserListDto>(user));
        }
        [HttpPost]
        public async Task<IActionResult> Index(AppUserListDto model,IFormFile resim)
        {
            if (ModelState.IsValid)
            {
                var guncellenecekUser=  _userManager.Users.FirstOrDefault(I=>I.Id ==model.Id);
                if (resim!=null)
                {
                    string uzanti = Path.GetExtension(resim.FileName);
                    string resimAd = Guid.NewGuid()+uzanti;
                    string path = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot/img/"+resimAd);
                    using (var stream = new FileStream(path,FileMode.Create))
                    {
                        await resim.CopyToAsync(stream);
                    }
                    guncellenecekUser.Picture =resimAd;
                }
                guncellenecekUser.Name=model.Name;
                guncellenecekUser.SurName=model.SurName;
                guncellenecekUser.Email=model.Email;

                var result =  await _userManager.UpdateAsync(guncellenecekUser);
                if (result.Succeeded)
                {
                    
                    TempData["message"] = "Güncelleme işlemi başarılı.";
                    return RedirectToAction("Index");
                }
                HataEkle(result.Errors);
            }
            return View(model);
        }
    }
}