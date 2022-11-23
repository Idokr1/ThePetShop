using Microsoft.AspNetCore.Mvc;
using ThePetShop.Repositories;

namespace ThePetShop.Controllers
{
    public class CatalogController : Controller
    {
        private IPetRepository _repository;

        public CatalogController(IPetRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index(string category)
        {
            return View(_repository.GetByCategory(category));
        }

        public IActionResult AnimalDetails(int animalId)
        {
            return View(_repository.ShowAnimalById(animalId));
        }

        public IActionResult AddComment(int animalId, string comment)
        {
            return View("AnimalDetails", _repository.AddComment(animalId, comment));
        }

    }

}
