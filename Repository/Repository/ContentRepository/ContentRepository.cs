using Repository.Data;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repository.ContentRepository
{
	public class ContentRepository :IContentRepository
	{
		private readonly NurgoDbContext _context;

		public ContentRepository(NurgoDbContext context)
		{
			_context = context;
		}

        public Advantage CreateAdvantage(Advantage advantage)
        {
            advantage.AddedDate = DateTime.Now;
            _context.Advantages.Add(advantage);
            _context.SaveChanges();
            return advantage;
        }

        public SliderItem CreateSlider(SliderItem sliderItem)
        {
            sliderItem.AddedDate = DateTime.Now;
			_context.SliderItems.Add(sliderItem);
			_context.SaveChanges();
			return sliderItem;
        }

        public void DeleteAdvantage(Advantage advantage)
        {
            _context.Advantages.Remove(advantage);
            _context.SaveChanges();
        }

        public void DeleteSliderItem(SliderItem sliderItem)
        {
			_context.SliderItems.Remove(sliderItem);

			_context.SaveChanges();
        }

        public Advantage GetAdvantageById(int id)
        {
            return _context.Advantages.Find(id);
        }

        public IEnumerable<Advantage> GetAdvantages()
		{
			return _context.Advantages.Where(s => s.Status)
									  .ToList();
		}

        public IEnumerable<Advantage> GetAdvantagesByStatus()
        {
			return _context.Advantages.ToList();
        }

        public IEnumerable<SliderItem> GetSliderItems()
		{
			return _context.SliderItems.Where(s => s.Status)
									   .OrderBy(o=>o.OrderBy)
					                   .ToList();
		}

        public SliderItem GetSliderItemsById(int id)
        {
			return _context.SliderItems.Find(id);
        }

        public IEnumerable<SliderItem> GetSliderItemsByStatus()
        {
            return _context.SliderItems.ToList();
        }

        public void UpdateAdvantage(Advantage advantageToUpdate, Advantage advantage)
        {
            advantageToUpdate.Status = advantage.Status;
            advantageToUpdate.Icon = advantage.Icon;
            advantageToUpdate.Title = advantage.Title;
            advantageToUpdate.Description = advantage.Description;
            advantageToUpdate.ModifiedBy = advantage.ModifiedBy;
            advantageToUpdate.ModifiedDate = DateTime.Now;

            _context.SaveChanges();
        }

        public void UpdateSliderItem(SliderItem slideritemToUpdate, SliderItem sliderItem)
        {
			slideritemToUpdate.Status = sliderItem.Status;
			slideritemToUpdate.Title = sliderItem.Title;
			slideritemToUpdate.Slogan= sliderItem.Slogan;
			slideritemToUpdate.Image = sliderItem.Image;
			slideritemToUpdate.ActionText= sliderItem.ActionText;
			slideritemToUpdate.EndPoint = sliderItem.EndPoint;
			slideritemToUpdate.ModifiedBy= sliderItem.ModifiedBy;
			slideritemToUpdate.ModifiedDate = DateTime.Now;

			_context.SaveChanges();
        }
    }
}
