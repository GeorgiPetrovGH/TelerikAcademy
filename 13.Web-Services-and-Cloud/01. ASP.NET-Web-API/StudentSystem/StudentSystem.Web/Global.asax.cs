namespace StudentSystem.Web
{
    using System.Web;
    using System.Web.Http;

    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            DatabaseConfig.Initialize();           
        }
    }
}
