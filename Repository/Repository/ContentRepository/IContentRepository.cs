using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Repository.ContentRepository
{
	public interface IContentRepository
	{
        IEnumerable<Setting> GetSettings();

        #region slider
        //Slider start
        IEnumerable<SliderItem>	GetSliderItems();
        IEnumerable<SliderItem> GetSliderItemsByStatus();
        SliderItem CreateSlider(SliderItem sliderItem);
        SliderItem GetSliderItemsById(int id);
        void UpdateSliderItem(SliderItem slideritemToUpdate, SliderItem sliderItem);
        void DeleteSliderItem(SliderItem sliderItem);
        //Slider End
        #endregion

        #region advantage
        //Advantages
        IEnumerable<Advantage>	GetAdvantages();
        IEnumerable<Advantage> GetAdvantagesByStatus();
        Advantage CreateAdvantage(Advantage advantage);
        Advantage GetAdvantageById(int id);
        void UpdateAdvantage(Advantage advantageToUpdate, Advantage advantage);
        void DeleteAdvantage(Advantage advantage);
        //Advantages end
        #endregion
    }
}
