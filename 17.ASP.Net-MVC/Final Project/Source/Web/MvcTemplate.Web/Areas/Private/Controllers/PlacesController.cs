namespace MvcTemplate.Web.Areas.Private.Controllers
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Web.Mvc;
    using Common;
    using Data.Models;
    using Infrastructure.Mapping;
    using Microsoft.AspNet.Identity;
    using Models;
    using Models.Comments;
    using Models.Images;
    using Models.Places;
    using Services.Data;
    using ViewModels.Categories;
    using ViewModels.Contracts;

    [Authorize]
    public class PlacesController : Controller
    {
        private const int ItemsPerPage = 10;
        private readonly IPlacesServices places;
        private readonly ICategoriesServices categories;
        private readonly ICommentsServices comments;
        private readonly IImagesServices images;

        public PlacesController(
            IPlacesServices places,
            ICategoriesServices categories,
            ICommentsServices comments,
            IImagesServices images)
        {
            this.places = places;
            this.categories = categories;
            this.comments = comments;
            this.images = images;
        }

        public ActionResult All(PlacesListViewModel viewModel)
        {
            if (viewModel.Page == null || viewModel.Page == 0)
            {
                viewModel.Page = 1;
            }

            if (viewModel.OrderBy == null)
            {
                viewModel.OrderBy = OrderByType.ByVotes;
            }

            if (viewModel.Search == null)
            {
                viewModel.Search = string.Empty;
            }

            var itemsCount = this.places.GetAllPlaces().Count(x => x.Name.Contains(viewModel.Search));
            var totalPages = (int)Math.Ceiling(itemsCount / (decimal)GlobalConstants.PlacesPerPage);

            var places = this.places.GetPlacesByPage((int)viewModel.Page, (OrderByType)viewModel.OrderBy, viewModel.Search)
                    .To<PlaceViewModel>()
                    .ToList();

            viewModel.TotalPages = totalPages;
            viewModel.Places = places;

            return this.View(viewModel);
        }

        public ActionResult Details(int id, int page = 1)
        {
            var place = this.places.GetPlaceById(id);
            var comments = this.comments.GetCommentsByPlaceId(id, page).To<CommentViewModel>().ToList();
            var images = this.images.GetImagesByPlaceId(place.Id).To<ImageViewModel>().ToList();

            var viewModel = new PlaceDetailsViewModel
            {
                Place = AutoMapperConfig.Configuration.CreateMapper().Map<PlaceViewModel>(place),
                PagesCount = this.comments.GetPagesByPlaceId(id),
                Comments = comments,
                Images = images
            };

            return this.View(viewModel);
        }

        [HttpGet]
        public ActionResult Create()
        {
            var categories = this.categories.GetAll()
                .To<CategoryViewModel>().ToList();

            var viewModel = new PlaceInputModel
            {
                Categories = categories
            };

            return this.View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PlaceInputModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(model);
            }

            var place = new Place()
            {
                Description = model.Description,
                Name = model.Name,
                AveragePrice = model.AveragePrice,
                CategoryId = model.CategoryId,
                CreatorId = this.User.Identity.GetUserId()
            };

            if (model.UploadedImage != null)
            {
                place.Images.Add(this.GetUploadedImage(model as IHaveImage));
            }

            this.places.CreatePlace(place);

            return this.Redirect("/Private/Places/Details/" + place.Id);
        }

        public Image GetUploadedImage(IHaveImage model)
        {
            using (var memory = new MemoryStream())
            {
                model.UploadedImage.InputStream.CopyTo(memory);
                var content = memory.GetBuffer();

                var fileExtension = model.UploadedImage.FileName.Split('.').Last();

                var image = new Image
                {
                    Content = content,
                    FileExtension = fileExtension
                };

                return image;
            }
        }
    }
}
