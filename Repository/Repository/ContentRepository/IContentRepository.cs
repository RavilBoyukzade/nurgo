using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Repository.ContentRepository
{
	public interface IContentRepository
	{
		IEnumerable<SliderItem>	GetSliderItems();
        IEnumerable<SliderItem> GetSliderItemsByStatus();
        IEnumerable<Advantage>	GetAdvantages();
		SliderItem CreateSlider(SliderItem sliderItem);
        SliderItem GetSliderItemsById(int id);
        void UpdateSliderItem(SliderItem slideritemToUpdate, SliderItem sliderItem);
        void DeleteSliderItem(SliderItem sliderItem);
        IEnumerable<Advantage> GetAdvantagesByStatus();
        Advantage CreateAdvantage(Advantage advantage);
        Advantage GetAdvantageById(int id);
        void UpdateAdvantage(Advantage advantageToUpdate, Advantage advantage);
        void DeleteAdvantage(Advantage advantage);
    }
}
