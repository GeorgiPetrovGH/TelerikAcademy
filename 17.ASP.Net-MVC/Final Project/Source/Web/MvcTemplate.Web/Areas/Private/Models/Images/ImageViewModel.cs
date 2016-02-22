namespace MvcTemplate.Web.Areas.Private.Models.Images
{
    using System;
    using AutoMapper;
    using MvcTemplate.Data.Models;
    using MvcTemplate.Web.Infrastructure.Mapping;

    public class ImageViewModel : IMapFrom<Image>
    {
        public int Id { get; set; }

        public byte[] Content { get; set; }

        public string FileExtension { get; set; }
    }
}
