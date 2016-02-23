namespace MvcTemplate.Web.ViewModels.Contracts
{
    using System.Web;

    public interface IHaveImage
    {
        HttpPostedFileBase UploadedImage { get; set; }
    }
}
