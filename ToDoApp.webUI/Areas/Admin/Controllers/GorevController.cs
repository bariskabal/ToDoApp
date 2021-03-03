using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ToDoApp.Business.Interfaces;
using ToDoApp.DTO.DTOs.GorevDtos;
using ToDoApp.Entities.Concrete;
using ToDoApp.webUI.StringInfo;

namespace ToDoApp.webUI.Areas.Admin.Controllers
{
    [Authorize(Roles=RoleInfo.Admin)]
    [Area(AreaInfo.Admin)]
    public class GorevController : Controller
    {
        private readonly IGorevService _gorevService;
        private readonly IAciliyetService _aciliyetService;
        private readonly IMapper _mapper;
        public GorevController(IMapper mapper,IGorevService gorevService,IAciliyetService aciliyetService)
        {
            _gorevService = gorevService;
            _aciliyetService = aciliyetService;
            _mapper=mapper;
        }
        public IActionResult Index()
        {
            TempData["Active"]=TempDataInfo.Gorev;
            return View(_mapper.Map<List<GorevListDto>>(_gorevService.GetirAciliyetIleTamamlanmayan()));
        }
        public IActionResult EkleGorev()
        {
            TempData["Active"]=TempDataInfo.Gorev;

           
            ViewBag.Aciliyetler =new SelectList(_aciliyetService.GetirHepsi(),"Id","Tanim");
            return View(new GorevAddDto());

        }
        [HttpPost]
        public IActionResult EkleGorev(GorevAddDto model)
        {
            if (ModelState.IsValid)
            {
                _gorevService.Kaydet(new Gorev{
                    Aciklama=model.Aciklama,
                    Ad=model.Ad,
                    AciliyetId=model.AciliyetId
                });
                return RedirectToAction("Index");
            }
            ViewBag.Aciliyetler =new SelectList(_aciliyetService.GetirHepsi(),"Id","Tanim",model.AciliyetId);
            return View(model);
        }
        public IActionResult GuncelleGorev(int id)
        {
            TempData["Active"]=TempDataInfo.Gorev;
            var gorev = _gorevService.GetirIdile(id);
            ViewBag.Aciliyetler =new SelectList(_aciliyetService.GetirHepsi(),"Id","Tanim",gorev.AciliyetId);
            return View(_mapper.Map<GorevUpdateDto>(gorev));
        }
        [HttpPost]
        public IActionResult GuncelleGorev(GorevUpdateDto model)
        {
            if (ModelState.IsValid)
            {
                _gorevService.Guncelle(new Gorev()
                {
                    Id=model.Id,
                    Aciklama=model.Aciklama,
                    AciliyetId=model.AciliyetId,
                    Ad=model.Ad
                });
                return RedirectToAction("Index");
            }
            ViewBag.Aciliyetler =new SelectList(_aciliyetService.GetirHepsi(),"Id","Tanim",model.AciliyetId);
            return View(model);
        }
        public IActionResult SilGorev(int id)
        {
            _gorevService.Sil(new Gorev{Id=id});
            return Json(null);
        }
         
    }
}