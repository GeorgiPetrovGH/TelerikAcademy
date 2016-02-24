namespace MvcTemplate.Web.Areas.Administration.Models.Categories
{
    using System;
    using Data.Models;
    using Infrastructure.Mapping;

    public class CategoriesGridViewModel : IMapFrom<Category>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public bool IsDeleted { get; set; }
    }
}