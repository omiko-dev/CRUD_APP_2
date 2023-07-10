using Microsoft.AspNetCore.Mvc;

namespace nika_2.Controllers
{
    public class HomeController : Controller
    {
        private readonly IShelvesRepository _shelvesRepository;

        public bool DeletePopUp = false;
        private bool AddPopUp = false;

        public HomeController(IShelvesRepository shelvesRepository)
        {
            _shelvesRepository = shelvesRepository;
        }

        public IActionResult Index()
        {
            IEnumerable<Shelves> Shelves = _shelvesRepository.GetAllShelves();
            ViewBag.delete = DeletePopUp;
            Console.WriteLine(ViewBag.delete);
            return View(Shelves);
        }


        public IActionResult AddShelve()
        {

            _shelvesRepository.SetShelves();

            return RedirectToAction("Index");

        }



        //[HttpGet("{id}")]
        public IActionResult DeleteShelve(int id)
        {
            Console.WriteLine("in");
            _shelvesRepository.Delete(id);


            return RedirectToAction("Index");

        }






        [HttpGet("UpdateShelve/{id}")]
        public IActionResult UpdateShelve()
        {
            return View();
        }


        [HttpPost("UpdateShelve/{id}")]
        public IActionResult UpdateShelve(int id, Shelves shelves)
        {

            if (ModelState.IsValid)
            {
                _shelvesRepository.UpdateShelves(id, shelves);

                return RedirectToAction("Index");

            }

            return View("UpdateShelve");

        }




    }
}
