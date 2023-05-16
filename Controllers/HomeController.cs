using Microsoft.AspNetCore.Mvc;
using MyStockControl.Business.Abstract;
using MyStockControl.UI.Models;
using System.Diagnostics;

namespace MyStockControl.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        ICustomerService _customerService;
        public HomeController(ICustomerService customerService)
        {
           _customerService = customerService;
        }

        public IActionResult Index()
        {
            var result = _customerService.GetAll();
            return View(result);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}