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
    public class SliderController : Controller
    {
        private  Repository.Models.Admin _admin => RouteData.Values["Admin"] as Repository.Models.Admin;
        private readonly IMapper _mapper;
        private readonly IContentRepository _contentRepository;

        public SliderController(IMapper mapper, IContentRepository contentRepository)
        {
            _mapper = mapper;
            _contentRepository = contentRepository;
        }

        public IActionResult Index()
        {
            var slideritems = _contentRepository.GetSliderItemsByStatus();
            var model = _mapper.Map<IEnumerable<SliderItem>,IEnumerable<SliderItemViewModel>>(slideritems);
            return View(model);
        }

        public IActionResult Create() 
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(SliderItemViewModel model)
        {
            if (ModelState.IsValid) 
            {
                SliderItem sliderItem = _mapper.Map<SliderItemViewModel, SliderItem>(model);
                sliderItem.AddedBy = _admin.Fullname;

                _contentRepository.CreateSlider(sliderItem);
                return RedirectToAction("index");
            }
            return View(model);
        }

        public IActionResult Edit(int id)
        {
            SliderItem sliderItem = _contentRepository.GetSliderItemsById(id);
            if (sliderItem == null) return NotFound();

            var model = _mapper.Map<SliderItem, SliderItemViewModel>(sliderItem);

            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(SliderItemViewModel model) 
        {
            if (ModelState.IsValid) 
            {
                SliderItem sliderItem = _mapper.Map<SliderItemViewModel, SliderItem>(model);
                sliderItem.ModifiedBy = _admin.Fullname;

                SliderItem slideritemToUpdate = _contentRepository.GetSliderItemsById(model.Id);
                if(slideritemToUpdate == null) return NotFound();
                _contentRepository.UpdateSliderItem(slideritemToUpdate, sliderItem);

                return RedirectToAction("index");
            }
            return View(model);
        }

        public IActionResult Delete (int id)
        {
            SliderItem sliderItem = _contentRepository.GetSliderItemsById(id);
            if (sliderItem == null) return NotFound();
            _contentRepository.DeleteSliderItem(sliderItem);

            return RedirectToAction("index");
        }
    }
}
