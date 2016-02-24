namespace MvcTemplate.Services.Data
{
    using System;
    using System.Linq;
    using MvcTemplate.Data.Common;
    using MvcTemplate.Data.Models;

    public class CategoriesServices : ICategoriesServices
    {
        private IDbRepository<Category> categories;

        public CategoriesServices(IDbRepository<Category> categories)
        {
            this.categories = categories;
        }

        public void DeleteCategory(int id)
        {
            var categoryToDelete = this.categories.GetById(id);
            this.categories.HardDelete(categoryToDelete);

            this.categories.Save();
        }

        public void EditCategory(int id, string name)
        {
            var categoryToBeEdited = this.categories.GetById(id);

            categoryToBeEdited.Name = name;

            this.categories.Save();
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
