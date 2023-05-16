using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyStockControl.Business.Abstract;
using MyStockControl.Business.Concrete;
using MyStockControl.DataAccess.Dal.Concrete;
using MyStockControl.Entities.Domain;


namespace MyStockControl.UI.Controllers
{
    public class ProductController : Controller
    {
        IProductService _productService;
        CategoryManager category = new CategoryManager(new EfCategoryDal());
       
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetProductList(int page=1)
        {


            var result = _productService.GetAll();
          
            
            return View(result);
        }

        [HttpGet]
        public IActionResult AddNewProduct(int CategoryId)
        {
            List<SelectListItem> categories=(from x in category.GetAll()
                                              select new SelectListItem
                                              {
                                                  Text = x.Name,
                                                  Value=x.CategoryId.ToString()
                                              }).ToList();
            ViewBag.categorydata = categories;
            return View();
        }

        [HttpPost]
        public IActionResult AddNewProduct(Product product)
        {

            var test = category.GetById(product.CategoryId);
            product.Category = test;
            _productService.AddProduct(product);
            return RedirectToAction("GetProductList");

        }

       
       public IActionResult DeleteProduct(int id)
        {
            var result=_productService.GetById(id);
            _productService.DeleteProduct(result);
            return RedirectToAction("GetProductList");
        }

        public IActionResult UpdateProductPage(int id)
        {
            var result = _productService.GetById(id);

            List<SelectListItem> categories = (from x in category.GetAll()
                                               select new SelectListItem
                                               {
                                                   Text = x.Name,
                                                   Value = x.CategoryId.ToString()
                                               }).ToList();
            ViewBag.categorydata = categories;

            return View("UpdateProductPage", result);
        }

        public IActionResult UpdateProduct(Product product)
        {
            _productService.UpdateProduct(product);
            return RedirectToAction("GetProductList");
        }
    }
}
