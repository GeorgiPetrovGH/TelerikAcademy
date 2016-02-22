namespace MvcTemplate.Web.Areas.Private.Controllers
{
    using System.Web.Mvc;

    public class UsersController : Controller
    {
        public ActionResult Info()
        {
            return this.View();
        }
    }
}