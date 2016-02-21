namespace MvcTemplate.Web.ViewModels.Home
{
    using System.Collections.Generic;

    public class IndexViewModel
    {
        public ICollection<IndexPlaceViewModel> Places { get; set; }
    }
}
