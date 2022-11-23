using Microsoft.AspNetCore.Mvc;
using ThePetShop.Repositories;

namespace ThePetShop.Controllers
{
    public class HomeController : Controller
    {
        private IPetRepository _repository;

        public HomeController(IPetRepository repository)
        {
            _repository = repository;
        }
        public IActionResult Index()
        {
            return View(_repository.GetTopAnimals());
        }
    }
}
