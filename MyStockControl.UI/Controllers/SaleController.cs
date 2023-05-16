using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyStockControl.Business.Abstract;
using MyStockControl.Business.Concrete;
using MyStockControl.DataAccess.Dal.Concrete;
using MyStockControl.Entities.Domain;

namespace MyStockControl.UI.Controllers
{
    public class SaleController : Controller
    {
        ISaleService _saleService;
        CustomerManager customer = new CustomerManager(new EfCustomerDal());
        ProductManager product = new ProductManager(new EfProductDal());
        public SaleController(ISaleService saleService)
        {
            _saleService = saleService;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult CreateNewSale(int productId, int customerId)
        {
            List<SelectListItem> customers = (from x in customer.GetAll()
                                               select new SelectListItem
                                               {
                                                   Text = x.FirstName,
                                                   Value = x.CustomerId.ToString()
                                               }).ToList();
            ViewBag.customerdata = customers;
            List<SelectListItem> products = (from x in product.GetAll()
                                               select new SelectListItem
                                               {
                                                   Text = x.Name,
                                                   Value = x.ProductId.ToString()
                                               }).ToList();
            ViewBag.productdata = products;
            return View();
        }

        [HttpPost]
        public IActionResult CreateNewSale(Sale sale)
        {
            var result = product.GetById(sale.ProductId);
            sale.TotalPrice = sale.Price * sale.Quantity;
            _saleService.AddSale(sale);
            return RedirectToAction("GetProductList", "Product");
        }
    }
}
