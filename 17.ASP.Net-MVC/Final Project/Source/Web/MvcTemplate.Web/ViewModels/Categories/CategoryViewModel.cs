namespace MvcTemplate.Web.ViewModels.Categories
{
    using MvcTemplate.Data.Models;
    using MvcTemplate.Web.Infrastructure.Mapping;

    public class CategoryViewModel : IMapFrom<Category>
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}