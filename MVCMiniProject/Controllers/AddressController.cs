using Microsoft.AspNetCore.Mvc;
using MVCMiniProject.Models;

namespace MVCMiniProject.Controllers
{
    public class AddressController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private static AddressModel _addressModel = new();

        public AddressController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public ActionResult Index()
        {
            return View(_addressModel);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(AddressModel model)
        {
            if (ModelState.IsValid == false)
            {
                _logger.LogWarning("User submitted invalid address");
                return View();
            }
            try
            {
                _addressModel = model;
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
