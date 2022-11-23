using Microsoft.AspNetCore.Mvc;
using ThePetShop.Models;
using ThePetShop.Repositories;

namespace ThePetShop.Controllers
{
    public class AdminController : Controller
    {
        private readonly IPetRepository _repository;
        public AdminController(IPetRepository repository)
        {
            _repository = repository;
        }
        public IActionResult Index(string category)
        {
            return View("Index", _repository.GetByCategory(category));
        }
        public IActionResult CreateAnimal()
        {
            return View("CreateAnimal");
        }


        public IActionResult Create(string name, int age, string description, string picturePath, int categoryID)
        {
            _repository.InsertAnimal(name, age, description, picturePath, categoryID);
            return View("Index", _repository.GetAnimal().Animals);
        }

        public IActionResult Edit(int id)
        {
            var animal = _repository.ShowAnimalById(id);
            return View("EditAnimal", animal);
        }
        public IActionResult Update(int id, Animal animal, int categoryID)
        {
            _repository.UpdateAnimal(id, animal, categoryID);
            return View("Index", _repository.GetAnimal().Animals);
        }
        public IActionResult Delete(int id)
        {
            _repository.DeleteAnimal(id);
            return View("Index", _repository.GetAnimal().Animals);
        }
    }
}
