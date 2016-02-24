namespace MvcTemplate.Web.Areas.Administration.Controllers
{
    using System.Linq;
    using System.Web.Mvc;
    using Common;
    using Data.Models;
    using Infrastructure.Mapping;
    using Kendo.Mvc.Extensions;
    using Kendo.Mvc.UI;
    using Models.Categories;
    using Services.Data;

    [Authorize(Roles = GlobalConstants.AdminRole)]
    public class CategoriesController : Controller
    {
        private readonly ICategoriesServices categories;

        public CategoriesController(ICategoriesServices categories)
        {
            this.categories = categories;
        }

        public ActionResult Index()
        {
            return this.View();
        }

        public ActionResult Categories_Read([DataSourceRequest]DataSourceRequest request)
        {
            IQueryable<Category> categories = this.categories.GetAll();
            DataSourceResult result = categories
                .To<CategoriesGridViewModel>()
                .ToDataSourceResult(request);

            return this.Json(result);
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Categories_Update([DataSourceRequest]DataSourceRequest request, Category category)
        {
            if (this.ModelState.IsValid)
            {
                this.categories.EditCategory(category.Id, category.Name);
            }

            return this.Json(new[] { category }.ToDataSourceResult(request, this.ModelState));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Categories_Destroy([DataSourceRequest]DataSourceRequest request, Category category)
        {
            this.categories.DeleteCategory(category.Id);

            return this.Json(new[] { category }.ToDataSourceResult(request, this.ModelState));
        }
    }
}
