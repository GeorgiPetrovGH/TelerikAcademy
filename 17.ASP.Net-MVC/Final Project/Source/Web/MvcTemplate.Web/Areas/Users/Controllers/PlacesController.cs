namespace MvcTemplate.Web.Areas.Users.Controllers
{
    using System.Web.Mvc;

    public class PlacesController : Controller
    {
        public ActionResult All()
        {
            return this.View();
        }
    }
}