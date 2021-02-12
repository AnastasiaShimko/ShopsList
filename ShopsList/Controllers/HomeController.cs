using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ShopsList.Business.Interfaces;
using ShopsList.Models;
using System.Diagnostics;
namespace ShopsList.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IShopRepository _repository;

        public HomeController(ILogger<HomeController> logger, IShopRepository repository)
        {
            _repository = repository;
            _logger = logger;
        }

        public IActionResult Index()
        {
            var Model = _repository.GetShops();
            return View(Model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult GetShopInfo(int shopId)
        {
            var shopInfo = _repository.GetShopInformationById(shopId);
            return Content(shopInfo);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
