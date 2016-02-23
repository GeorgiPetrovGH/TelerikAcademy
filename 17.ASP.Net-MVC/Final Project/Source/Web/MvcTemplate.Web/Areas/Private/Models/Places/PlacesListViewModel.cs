namespace MvcTemplate.Web.Areas.Private.Models
{
    using System.Collections.Generic;
    using Common;

    public class PlacesListViewModel
    {
        public int? Page { get; set; }

        public int TotalPages { get; set; }

        public OrderByType? OrderBy { get; set; }

        public string Search { get; set; }

        public IEnumerable<PlaceViewModel> Places { get; set; }
    }
}
