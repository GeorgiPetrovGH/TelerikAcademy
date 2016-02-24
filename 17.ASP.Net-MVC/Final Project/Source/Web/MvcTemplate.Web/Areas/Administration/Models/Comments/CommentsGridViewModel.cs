namespace MvcTemplate.Web.Areas.Administration.Models.Comments
{
    using System;
    using AutoMapper;
    using Data.Models;
    using Infrastructure.Mapping;

    public class CommentsGridViewModel : IMapFrom<Comment>, IHaveCustomMappings
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Text { get; set; }

        public string PlaceName { get; set; }

        public string CreatorName { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public bool IsDeleted { get; set; }

        public void CreateMappings(IMapperConfiguration configuration)
        {
            configuration.CreateMap<Comment, CommentsGridViewModel>()
                .ForMember(x => x.CreatorName, opt => opt.MapFrom(x => x.Creator.UserName))
                .ForMember(x => x.PlaceName, opt => opt.MapFrom(x => x.Place.Name));
        }
    }
}