using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCMiniProject.Models;

namespace MVCMiniProject.Controllers
{
    public class PersonController : Controller
    {
        private static List<PersonModel> _persons = new();
        public ActionResult Index()
        {
            return View(_persons);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PersonModel model)
        {
            try
            {
                _persons.Add(model);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

    }
}
