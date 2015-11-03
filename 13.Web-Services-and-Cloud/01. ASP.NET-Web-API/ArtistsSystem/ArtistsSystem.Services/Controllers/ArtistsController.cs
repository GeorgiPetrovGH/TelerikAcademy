namespace ArtistsSystem.Services.Controllers
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.Http;

    using ArtistsSystem.Models;    
    using Globals;    
    using Models;

    public class ArtistsController : BaseController
    {
        [HttpGet]
        public ICollection<Artist> Get()
        {
            ICollection<Artist> artists = this.data.ArtistsRepository.All().ToList();
            return artists;
        }

        [HttpPost]
        public IHttpActionResult Post(ArtistRequestModel request)
        {
            if (request == null)
            {
                return this.BadRequest(GlobalMessages.EntityMustNotBeNullMessage);
            }

            var singer = new Artist
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                Age = request.Age
            };

            Country defaultCountry = this.data.CountriesRepository.All().FirstOrDefault();

            singer.Country = defaultCountry;
            this.data.ArtistsRepository.Add(singer);
            int result = this.data.SaveChanges();
            return this.Ok($"{GlobalMessages.EntitySuccessfullyAddedMessage} - {result}");
        }

        [HttpDelete]
        public IHttpActionResult Delete(string id)
        {
            if (id == null)
            {
                return this.BadRequest(GlobalMessages.IdMustNotBeNullMessage);
            }

            this.data.ArtistsRepository.Delete(id);
            int result = this.data.SaveChanges();
            return this.Ok($"{GlobalMessages.EntitySuccessfullyDeletedMessage} - {result}");
        }

        [HttpPut]
        public IHttpActionResult Update(string id, ArtistRequestModel request)
        {
            if (id == null)
            {
                return this.BadRequest(GlobalMessages.IdMustNotBeNullMessage);
            }

            if (request == null)
            {
                return this.BadRequest(GlobalMessages.EntityMustNotBeNullMessage);
            }

            Artist entity = this.data.ArtistsRepository.FindById(id);
            if (entity == null)
            {
                return this.BadRequest(GlobalMessages.EntityDoesNotExist);
            }

            // Map the request model to the db model
            if (request.FirstName != default(string))
            {
                entity.FirstName = request.FirstName;
            }

            if (request.LastName != default(string))
            {
                entity.LastName = request.LastName;
            }

            if (request.Age != default(short))
            {
                entity.Age = request.Age;
            }

            this.data.ArtistsRepository.Update(entity);
            int result = this.data.SaveChanges();
            return this.Ok($"{GlobalMessages.EntitySuccessfullyUpdatedMessage} - {result}");
        }
    }
}