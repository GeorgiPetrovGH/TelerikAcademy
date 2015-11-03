namespace ArtistsSystem.Services
{
    using Data;
    using Data.Migrations;
    using System.Data.Entity;
    using System.Web.Http;

    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ArtistsSystemDbContext, Configuration>());

            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
