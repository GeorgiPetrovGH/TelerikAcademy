namespace MvcTemplate.Web.Areas.Administration.Models.Images
{
    using System;
    using AutoMapper;
    using Data.Models;
    using Infrastructure.Mapping;

    public class ImagesGridViewModel : IMapFrom<Image>, IHaveCustomMappings
    {
        public int Id { get; set; }

        public string FileExtension { get; set; }

        public string PlaceName { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public bool IsDeleted { get; set; }

        public void CreateMappings(IMapperConfiguration configuration)
        {
            configuration.CreateMap<Image, ImagesGridViewModel>()
                .ForMember(x => x.PlaceName, opt => opt.MapFrom(x => x.Place.Name));
        }
    }
}