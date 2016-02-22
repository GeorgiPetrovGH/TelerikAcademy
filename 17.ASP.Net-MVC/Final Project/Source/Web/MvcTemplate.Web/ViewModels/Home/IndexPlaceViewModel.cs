namespace MvcTemplate.Web.ViewModels.Home
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using Data.Models;
    using Infrastructure.Mapping;

    public class IndexPlaceViewModel : IMapFrom<Place>
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public double AveragePrice { get; set; }

        public int CategoryId { get; set; }

        public string CreatorId { get; set; }
    }
}