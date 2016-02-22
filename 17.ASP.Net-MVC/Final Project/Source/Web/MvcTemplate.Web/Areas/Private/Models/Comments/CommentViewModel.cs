namespace MvcTemplate.Web.Areas.Private.Models.Comments
{
    using System;
    using AutoMapper;
    using MvcTemplate.Data.Models;
    using MvcTemplate.Web.Infrastructure.Mapping;

    public class CommentViewModel : IMapFrom<Comment>
    {
        public string Text { get; set; }

        public string CreatorName { get; set; }

        public DateTime CreatedOn { get; set; }
    }
}