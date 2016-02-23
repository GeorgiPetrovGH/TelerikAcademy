namespace MvcTemplate.Web.Areas.Private.Models.Places
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using AutoMapper;
    using Comments;
    using Data.Models;
    using Images;
    using Infrastructure.Mapping;

    public class PlaceDetailsViewModel : IMapFrom<Place>, IHaveCustomMappings
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public double AveragePrice { get; set; }

        public string CategoryName { get; set; }

        public string CreatorName { get; set; }

        public DateTime CreatedOn { get; set; }

        public int PagesCount { get; set; }

        public int? RatingValue { get; set; }

        public int? RatingCount { get; set; }

        public ICollection<CommentViewModel> Comments { get; set; }

        public ICollection<ImageViewModel> Images { get; set; }

        public void CreateMappings(IMapperConfiguration configuration)
        {
            configuration.CreateMap<Place, PlaceDetailsViewModel>()
                .ForMember(x => x.RatingValue, opt => opt.MapFrom(x => x.Ratings.Sum(v => v.Value)))
                .ForMember(x => x.CategoryName, opt => opt.MapFrom(x => x.Category.Name))
                .ForMember(x => x.CreatorName, opt => opt.MapFrom(x => x.Creator.UserName))
                .ForMember(x => x.RatingCount, opt => opt.MapFrom(x => x.Ratings.Count()));
        }
    }
}
