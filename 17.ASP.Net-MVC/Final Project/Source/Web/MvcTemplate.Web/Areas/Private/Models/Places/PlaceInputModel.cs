namespace MvcTemplate.Web.Areas.Private.Models.Places
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Web;
    using Common;
    using MvcTemplate.Data.Models;
    using MvcTemplate.Web.Infrastructure.Mapping;
    using ViewModels.Categories;
    using ViewModels.Contracts;

    public class PlaceInputModel : IMapFrom<Place>, IHaveImage
    {
        [Required]
        [MinLength(GlobalConstants.PlaceNameMinLength)]
        [MaxLength(GlobalConstants.PlaceNameMaxLength)]
        public string Name { get; set; }

        [Required]
        [MinLength(GlobalConstants.PlaceDescriptionMinLength)]
        [MaxLength(GlobalConstants.PlaceDescriptionMaxLength)]
        public string Description { get; set; }

        public double AveragePrice { get; set; }

        [Required]
        [Display(Name = "Category Name")]
        public int CategoryId { get; set; }

        public HttpPostedFileBase UploadedImage { get; set; }

        public ICollection<CategoryViewModel> Categories { get; set; }
    }
}
