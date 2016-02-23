namespace MvcTemplate.Web.Areas.Private.Models.Places
{
    using System;
    using System.Collections.Generic;
    using AutoMapper;
    using Comments;
    using Data.Models;
    using Images;
    using Infrastructure.Mapping;

    public class PlaceDetailsViewModel : IMapFrom<Place>
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

        public ICollection<ImageViewModel> Images { get; set; }
    }
}
