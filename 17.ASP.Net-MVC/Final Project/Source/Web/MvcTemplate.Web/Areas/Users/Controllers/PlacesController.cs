namespace MvcTemplate.Web.Areas.Users.Controllers
{
    using System.Web.Mvc;

    public class PlacesController : Controller
    {
        // GET: Users/Places
        public ActionResult All()
        {
            return this.View();
        }
    }
}