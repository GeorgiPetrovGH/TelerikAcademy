namespace MvcTemplate.Web.ViewModels.Home
{
    using System.Linq;
    using Areas.Private.Models.Images;
    using AutoMapper;
    using Data.Models;
    using Infrastructure.Mapping;

    public class IndexPlaceViewModel : IMapFrom<Place>, IHaveCustomMappings
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string CategoryName { get; set; }

        public int? RatingValue { get; set; }

        public ImageViewModel Image { get; set; }

        public void CreateMappings(IMapperConfiguration configuration)
        {
            configuration.CreateMap<Place, IndexPlaceViewModel>()
                .ForMember(x => x.RatingValue, opt => opt.MapFrom(x => x.Ratings.Sum(v => v.Value)))
                .ForMember(x => x.CategoryName, opt => opt.MapFrom(x => x.Category.Name));
        }
    }
}
