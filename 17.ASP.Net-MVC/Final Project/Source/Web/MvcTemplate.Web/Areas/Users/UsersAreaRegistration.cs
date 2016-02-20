namespace MvcTemplate.Web.Areas.Users
{
    using System.Web.Mvc;

    public class UsersAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Users";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Users_default",
                "{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional });
        }
    }
}
