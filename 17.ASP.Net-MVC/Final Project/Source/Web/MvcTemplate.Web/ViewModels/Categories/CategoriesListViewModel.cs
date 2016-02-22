namespace MvcTemplate.Web.ViewModels.Categories
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Web.Mvc;

    public class CategoriesListViewModel
    {
        public ICollection<CategoryViewModel> Categories { get; set; }
    }
}