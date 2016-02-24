namespace MvcTemplate.Services.Data
{    
    using System.Linq;
    using MvcTemplate.Data.Models;

    public interface IRatingsServices
    {
        Rating AddRatingToPlace(Rating rating);

        IQueryable<Rating> GetAll();

        void EditRating(int id, int value);

        void DeleteRating(int id);
    }
}
