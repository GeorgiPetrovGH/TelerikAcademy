namespace MvcTemplate.Web.Areas.Administration.Models.Places
{
    using System;
    using AutoMapper;
    using Data.Models;
    using Infrastructure.Mapping;

    public class PlacesGridViewModel : IMapFrom<Place>, IHaveCustomMappings
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string CreatorName { get; set; }

        public double AveragePrice { get; set; }

        public string CategoryName { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public bool IsDeleted { get; set; }

        public void CreateMappings(IMapperConfiguration configuration)
        {
            configuration.CreateMap<Place, PlacesGridViewModel>()
                .ForMember(x => x.CreatorName, opt => opt.MapFrom(x => x.Creator.UserName))
                .ForMember(x => x.CategoryName, opt => opt.MapFrom(x => x.Category.Name));
        }
    }
}