namespace MvcTemplate.Web.Areas.Private.Models.Users
{
    using System.Collections.Generic;

    public class UserInfoViewModel
    {
        public string UserName { get; set; }

        public IEnumerable<PlaceViewModel> Places { get; set; }
    }
}
