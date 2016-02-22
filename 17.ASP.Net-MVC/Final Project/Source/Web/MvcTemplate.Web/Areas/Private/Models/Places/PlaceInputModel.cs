namespace MvcTemplate.Web.Areas.Private.Models.Places
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Web;
    using System.Web.Mvc;
    using AutoMapper;
    using MvcTemplate.Data.Models;
    using MvcTemplate.Web.Infrastructure.Mapping;
    using ViewModels.Categories;

    public class PlaceInputModel : IMapFrom<Place>
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public double AveragePrice { get; set; }

        [Display(Name = "Category Name")]
        public int CategoryId { get; set; }

        public HttpPostedFileBase UploadedImage { get; set; }

        public ICollection<CategoryViewModel> Categories { get; set;
        }
    }
}
