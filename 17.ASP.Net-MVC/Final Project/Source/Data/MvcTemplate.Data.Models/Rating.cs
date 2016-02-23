namespace MvcTemplate.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using Common.Models;
    using MvcTemplate.Common;

    public class Rating : BaseModel<int>
    {   
        [Required]
        [Range(GlobalConstants.RatingMinValue, GlobalConstants.RatingMaxValue)]
        public int Value { get; set; }

        public string CreatorId { get; set; }

        [ForeignKey("CreatorId")]
        public virtual User Creator { get; set; }

        public int PlaceId { get; set; }

        [ForeignKey("PlaceId")]
        public virtual Place Place { get; set; }
    }
}