namespace MvcTemplate.Web.Areas.Private.Models.Categories
{
    using System.Collections.Generic;

    public class CategoriesIndexViewModel
    {
        public string CategoryName { get; set; }

        public IEnumerable<PlaceViewModel> Places { get; set; }
    }
}
