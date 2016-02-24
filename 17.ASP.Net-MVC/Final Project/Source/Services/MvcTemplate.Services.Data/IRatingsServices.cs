namespace MvcTemplate.Services.Data
{
    using MvcTemplate.Data.Models;

    public interface IRatingsServices
    {
        Rating AddRatingToPlace(Rating rating);
    }
}
