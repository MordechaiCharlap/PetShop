using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PetShop.Client.Models;
using PetShop.Service;
using PetShop.Service.Interfaces;

namespace PetShop.Client.Controllers
{
    public class CatalogController : Controller
    {
        private readonly IAnimalService animalService;
        private readonly ICommentService commentService;
        private readonly ICategoryService categoryService;
        private readonly IRepositoryFactory repositoryFactory;
        public CatalogController()
        {
            this.repositoryFactory = new RepositoryFactory();
            this.animalService = new AnimalService(repositoryFactory.CreateAnimalRepo());
            this.commentService = new CommentService(repositoryFactory.CreateCommentRepo());
            this.categoryService = new CategoryService(repositoryFactory.CreateCategoryRepo());
        }
        // GET: CatalogController
        public ActionResult Index()
        {
            //Show all animals

            return View(new CatalogViewModel(animalService.GetAll(),categoryService.GetAll()));
        }

        // GET: CatalogController/Details/5
        public ActionResult Details(int id)
        {
            //Show Animal Details
            return View(new AnimalDetailsViewModel(animalService.Get(id), commentService.GetByAnimalId(id)));
        }
        // GET: CatalogController/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        // POST: CatalogController/Create
        //    [HttpPost]
        //    [ValidateAntiForgeryToken]
        //    public ActionResult Create(IFormCollection collection)
        //    {
        //        try
        //        {
        //            return RedirectToAction(nameof(Index));
        //        }
        //        catch
        //        {
        //            return View();
        //        }
        //    }

        //    // GET: CatalogController/Edit/5
        //    public ActionResult Edit(int id)
        //    {
        //        return View();
        //    }

        //    // POST: CatalogController/Edit/5
        //    [HttpPost]
        //    [ValidateAntiForgeryToken]
        //    public ActionResult Edit(int id, IFormCollection collection)
        //    {
        //        try
        //        {
        //            return RedirectToAction(nameof(Index));
        //        }
        //        catch
        //        {
        //            return View();
        //        }
        //    }

        //    // GET: CatalogController/Delete/5
        //    public ActionResult Delete(int id)
        //    {
        //        return View();
        //    }

        //    // POST: CatalogController/Delete/5
        //    [HttpPost]
        //    [ValidateAntiForgeryToken]
        //    public ActionResult Delete(int id, IFormCollection collection)
        //    {
        //        try
        //        {
        //            return RedirectToAction(nameof(Index));
        //        }
        //        catch
        //        {
        //            return View();
        //        }
        //    }
        //}
    }
}
