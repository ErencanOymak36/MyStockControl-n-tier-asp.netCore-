using Microsoft.AspNetCore.Mvc;
using MyStockControl.Business.Abstract;
using MyStockControl.Entities.Domain;

namespace MyStockControl.UI.Controllers
{
    public class CustomerController : Controller
    {
        ICustomerService _customerService;
        Customer db= new Customer();
        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetCustomerList()
        {
            var result=_customerService.GetAll();
            return View(result);
        }

        public IActionResult DeleteCustomer(int id)
        {
            var result=_customerService.GetById(id);
            _customerService.DeleteCustomer(result);
            return RedirectToAction("GetCustomerList");
            
        }
        [HttpPost]
        public IActionResult AddNewCustomer(Customer customer)
        {
            
                _customerService.AddCustomer(customer);
            
             
            return RedirectToAction("GetCustomerList");
        }

        public IActionResult UpdateCustomerPage(int id)
        {
            var result = _customerService.GetById(id);
            return View("UpdateCustomerPage",result);
        }

        public IActionResult UpdateCustomer(Customer customer)
        {
            _customerService.UpdateCustomer(customer);
            return RedirectToAction("GetCustomerList");
        }
    }
}
