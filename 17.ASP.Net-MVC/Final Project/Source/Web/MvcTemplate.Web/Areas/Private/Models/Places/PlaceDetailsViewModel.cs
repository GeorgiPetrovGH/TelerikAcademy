namespace MvcTemplate.Web.Areas.Private.Models.Places
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using AutoMapper;
    using Comments;
    using Data.Models;
    using Infrastructure.Mapping;

    public class PlaceDetailsViewModel : IMapFrom<Place>, IHaveCustomMappings
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public double AveragePrice { get; set; }

        public int CategoryId { get; set; }

        public string CreatorId { get; set; }

        public DateTime CreatedOn { get; set; }

        public int PagesCount { get; set; }

        public ICollection<CommentViewModel> Comments { get; set; }

        public void CreateMappings(IMapperConfiguration configuration)
        {
            //configuration.CreateMap<Joke, JokeViewModel>()
            //    .ForMember(x => x.Category, opt => opt.MapFrom(x => x.Category.Name));
        }
    }
}