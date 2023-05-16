using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using MyStockControl.Business.Abstract;
using MyStockControl.Entities.Domain;

namespace MyStockControl.UI.Controllers
{
    public class CategoryController : Controller
    {
        ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        public IActionResult Index()
        {
           
            return View();
        }
        public IActionResult GetCategoryList()
        {
            var result = _categoryService.GetAll();
            return View(result);
        }

        public IActionResult DeleteCategory(int id)
        {
            var result=_categoryService.GetById(id);
            _categoryService.DeleteCategory(result);
            return RedirectToAction("GetCategoryList");
        }

        [HttpPost]
        public IActionResult AddNewCategory(Category category)
        {
            _categoryService.AddCategory(category);
            return RedirectToAction("GetCategoryList");
        }

        public IActionResult UpdateCategoryPage(int id)
        {
            var result = _categoryService.GetById(id);
            return View("UpdateCategoryPage", result);

        }
        public IActionResult UpdateCategory(Category category)
        {
           
            _categoryService.UpdateCategory(category);
            return RedirectToAction("GetCategoryList");
        }
    }
}
