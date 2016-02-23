namespace MvcTemplate.Web.Areas.Private.Models.Places
{
    using System.Collections.Generic;
    using Comments;
    using Images;

    public class PlaceDetailsViewModel
    {
        public int PagesCount { get; set; }

        public PlaceViewModel Place { get; set; }

        public ICollection<CommentViewModel> Comments { get; set; }

        public ICollection<ImageViewModel> Images { get; set; }
    }
}
