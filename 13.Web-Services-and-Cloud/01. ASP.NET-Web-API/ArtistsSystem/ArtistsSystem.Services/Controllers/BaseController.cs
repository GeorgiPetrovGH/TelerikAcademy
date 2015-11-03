namespace ArtistsSystem.Services.Controllers
{
    using System.Web.Http;

    using Data;
    using Data.Data;    

    public class BaseController : ApiController
    {
        protected readonly IArtistsSystemData data;

        public BaseController()
        {
            this.data = new ArtistsSystemData(new ArtistsSystemDbContext());
        }
    }
}