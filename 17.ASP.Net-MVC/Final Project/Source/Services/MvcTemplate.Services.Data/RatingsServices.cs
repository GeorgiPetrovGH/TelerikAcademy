namespace MvcTemplate.Services.Data
{
    using MvcTemplate.Data.Common;
    using MvcTemplate.Data.Models;
    using System.Linq;

    public class RatingsServices : IRatingsServices
    {
        private readonly IDbRepository<Rating> ratings;

        public RatingsServices(IDbRepository<Rating> ratings)
        {
            this.ratings = ratings;
        }

        public Rating AddRatingToPlace(Rating rating)
        {
            var ratingByUser = this.ratings.All()
                .Where(x => x.CreatorId == rating.CreatorId && x.PlaceId == rating.PlaceId)
                .FirstOrDefault();

            if(ratingByUser == null)
            {
                this.ratings.Add(rating);
                this.ratings.Save();
            }
            return rating;
        }
    }
}
