namespace MvcTemplate.Web.Areas.Private.Models.Comments
{
    using System;
    using AutoMapper;
    using Data.Models;
    using Infrastructure.Mapping;

    public class CommentViewModel : IMapFrom<Comment>, IHaveCustomMappings
    {
        public string Name { get; set; }

        public string Text { get; set; }

        public string CreatorName { get; set; }

        public DateTime CreatedOn { get; set; }

        public void CreateMappings(IMapperConfiguration configuration)
        {
            configuration.CreateMap<Comment, CommentViewModel>()
                .ForMember(x => x.CreatorName, opt => opt.MapFrom(x => x.Creator.UserName));
        }
    }
}
