namespace MvcTemplate.Web.Areas.Administration.Models.Ratings
{
    using System;
    using AutoMapper;
    using Data.Models;
    using Infrastructure.Mapping;

    public class RatingsGridViewModel : IMapFrom<Rating>, IHaveCustomMappings
    {
        public int Id { get; set; }

        public int Value { get; set; }

        public string PlaceName { get; set; }

        public string CreatorName { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public bool IsDeleted { get; set; }

        public void CreateMappings(IMapperConfiguration configuration)
        {
            configuration.CreateMap<Rating, RatingsGridViewModel>()
                .ForMember(x => x.CreatorName, opt => opt.MapFrom(x => x.Creator.UserName))
                .ForMember(x => x.PlaceName, opt => opt.MapFrom(x => x.Place.Name));
        }
    }
}