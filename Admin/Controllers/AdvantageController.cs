using Admin.Filters;
using Admin.Models.Addings;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Repository.Repository.ContentRepository;
using System.Collections.Generic;

namespace Admin.Controllers
{
    [TypeFilter(typeof(Auth))]
    public class AdvantageController : Controller
    {
        private Repository.Models.Admin _admin => RouteData.Values["Admin"] as Repository.Models.Admin;
        private readonly IMapper _mapper;
        private readonly IContentRepository _contentRepository;

        public AdvantageController(IMapper mapper, IContentRepository contentRepository)
        {
            _mapper = mapper;
            _contentRepository = contentRepository;
        }
        public IActionResult Index()
        {
            var advantage = _contentRepository.GetAdvantagesByStatus();
            var model = _mapper.Map<IEnumerable<Advantage>, IEnumerable<AdvantageViewModel>>(advantage);
            return View(model);
        }
        public IActionResult Create() 
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(AdvantageViewModel model)
        {
            if (ModelState.IsValid)
            {
                Advantage advantage = _mapper.Map<AdvantageViewModel, Advantage>(model);
                advantage.AddedBy = _admin.Fullname;

                _contentRepository.CreateAdvantage(advantage);
                return RedirectToAction("index");
            }
            return View(model);
        }
        public IActionResult Edit(int id)
        {
            Advantage advantage = _contentRepository.GetAdvantageById(id);
            if (advantage == null) return NotFound();

            var model = _mapper.Map<Advantage, AdvantageViewModel>(advantage);

            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(AdvantageViewModel model)
        {
            if (ModelState.IsValid)
            {
                Advantage advantage = _mapper.Map<AdvantageViewModel, Advantage>(model);
                advantage.ModifiedBy = _admin.Fullname;

                Advantage advantageToUpdate = _contentRepository.GetAdvantageById(model.Id);
                if (advantageToUpdate == null) return NotFound();
                _contentRepository.UpdateAdvantage(advantageToUpdate, advantage);

                return RedirectToAction("index");
            }
            return View(model);
        }

        public IActionResult Delete(int id)
        {
            Advantage advantage = _contentRepository.GetAdvantageById(id);
            if (advantage == null) return NotFound();
            _contentRepository.DeleteAdvantage(advantage);

            return RedirectToAction("index");
        }

    }
}
