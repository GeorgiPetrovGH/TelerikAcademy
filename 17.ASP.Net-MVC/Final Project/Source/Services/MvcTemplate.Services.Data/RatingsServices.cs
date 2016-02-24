namespace MvcTemplate.Services.Data
{
    using MvcTemplate.Data.Common;
    using MvcTemplate.Data.Models;
    using System.Linq;
    using System;

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

        public void DeleteRating(int id)
        {
            var ratingToDelete = this.ratings.GetById(id);
            this.ratings.HardDelete(ratingToDelete);

            this.ratings.Save();
        }

        public void EditRating(int id, int value)
        {
            var ratingToBeEdited = this.ratings.GetById(id);

            ratingToBeEdited.Value = value;

            this.ratings.Save();
        }

        public IQueryable<Rating> GetAll()
        {
            return this.ratings.All();
        }
    }
}
