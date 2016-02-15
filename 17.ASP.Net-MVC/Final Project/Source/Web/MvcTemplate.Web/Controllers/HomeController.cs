namespace MvcTemplate.Web.Controllers
{
    using System.Linq;
    using System.Web.Mvc;

    using ViewModels.Home;
    using Infrastructure.Mapping;
    using Services.Data;
    using Data;

    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            var db = new ApplicationDbContext();
            var usersCount = db.Users.Count();

            return this.View();
        }
    }
}
