﻿namespace ArtistsSystem.Services.Controllers
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.Http;

    using ArtistsSystem.Models;
    using Globals;    
    using Models;
    

    public class AlbumsController : BaseController
    {
        [HttpGet]
        public ICollection<Album> Get()
        {
            ICollection<Album> albums = this.data.AlbumsRepository.All().ToList();
            return albums;
        }

        [HttpPost]
        public IHttpActionResult Post(AlbumRequestModel request)
        {
            if (request == null)
            {
                return this.BadRequest(GlobalMessages.EntityMustNotBeNullMessage);
            }

            var album = new Album
            {
                Title = request.Title,
                Year = request.Year
            };

            Artist defaultArtist = this.data.ArtistsRepository.All().FirstOrDefault();
            Producer defaultProducer = this.data.ProducersRepository.All().FirstOrDefault();
            album.Singers.Add(defaultArtist);
            album.Producer = defaultProducer;

            this.data.AlbumsRepository.Add(album);
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

            this.data.AlbumsRepository.Delete(id);
            int result = this.data.SaveChanges();
            return this.Ok($"{GlobalMessages.EntitySuccessfullyDeletedMessage} - {result}");
        }

        [HttpPut]
        public IHttpActionResult Update(string id, AlbumRequestModel request)
        {
            if (id == null)
            {
                return this.BadRequest(GlobalMessages.IdMustNotBeNullMessage);
            }

            if (request == null)
            {
                return this.BadRequest(GlobalMessages.EntityMustNotBeNullMessage);
            }

            Album entity = this.data.AlbumsRepository.FindById(id);
            if (entity == null)
            {
                return this.BadRequest(GlobalMessages.EntityDoesNotExist);
            }
                        
            if (request.Title != default(string))
            {
                entity.Title = request.Title;
            }

            if (request.Year != default(short))
            {
                entity.Year = request.Year;
            }

            this.data.AlbumsRepository.Update(entity);
            int result = this.data.SaveChanges();
            return this.Ok($"{GlobalMessages.EntitySuccessfullyUpdatedMessage} - {result}");
        }
    }
}