namespace MvcTemplate.Services.Data
{
    using MvcTemplate.Data.Common;
    using MvcTemplate.Data.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class CategoriesServices : ICategoriesServices
    {
        private IDbRepository<Category> categories;

        public CategoriesServices(IDbRepository<Category> categories)
        {
            this.categories = categories;
        }

        public Category EnsureCategory(string name)
        {
            var category = this.categories.All().FirstOrDefault(x => x.Name == name);
            if (category != null)
            {
                return category;
            }

            category = new Category() { Name = name };
            this.categories.Add(category);
            this.categories.Save();
            return category;
        }

        public IQueryable<Category> GetAll()
        {
            return this.categories.All().OrderBy(x => x.Name);
        }
    }
}
