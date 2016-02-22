namespace MvcTemplate.Services.Data
{ 
    using System.Linq;
    
    using MvcTemplate.Data.Common;
    using MvcTemplate.Data.Models;

    public interface ICategoriesServices
    {
        IQueryable<Category> GetAll();

        Category EnsureCategory(string name);        
    }    
}
