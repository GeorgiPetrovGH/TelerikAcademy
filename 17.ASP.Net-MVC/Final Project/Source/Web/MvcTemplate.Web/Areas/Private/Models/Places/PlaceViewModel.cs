namespace MvcTemplate.Web.Areas.Private.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using AutoMapper;
    using Data.Models;
    using Infrastructure.Mapping;

    public class PlaceViewModel : IMapFrom<Place>, IHaveCustomMappings
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public double AveragePrice { get; set; }

        public int CategoryId { get; set; }

        public string CreatorId { get; set; }

        public DateTime CreatedOn { get; set; }

        public int? RatingValue { get; set; }

        public void CreateMappings(IMapperConfiguration configuration)
        {
            configuration.CreateMap<Place, PlaceViewModel>()
                .ForMember(x => x.RatingValue, opt => opt.MapFrom(x => x.Ratings.Sum(v => v.Value)));
        }
    }
}
