using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProductsAndCategories.Models;
using Microsoft.EntityFrameworkCore;

namespace ProductsAndCategories.Controllers
{
    public class HomeController : Controller
    {
        private MyContext dbContext;
        public HomeController(MyContext context)
        {
            dbContext = context;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            return Redirect("products");
        }
        
        [HttpGet("products")]
        public IActionResult ShowProducts()
        {
            ViewModel ProductVM = new ViewModel()
            {
                AllProducts = dbContext.Products.ToList()
                
            };
  
            return View("Products", ProductVM);
        }
        [HttpPost("products/add")]
        public IActionResult AddProduct(Product NewProduct)
        {
            Product AddProduct = new Product()
            {
                Name = NewProduct.Name,
                Description = NewProduct.Description,
                Price = NewProduct.Price
            };
            dbContext.Add(AddProduct);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }


        [HttpGet("products/{id}")]
        public IActionResult ViewProduct(int id)
        {
            ViewModel ViewThisProduct = new ViewModel()
            {
                AllCategories = dbContext.Categories
                .Include(cat => cat.CategoryProducts)
                .ThenInclude(ass => ass.Category)
                .Where(c => c.CategoryProducts
                .Any(ass => ass.ProductId == id)== false)
                .ToList(),

                ViewProduct = dbContext.Products
                .Include(prod => prod.ProductCategories)
                .ThenInclude(ass => ass.Category)
                .FirstOrDefault(p => p.ProductId == id)

            };
            return View("ShowProduct", ViewThisProduct);
        }
        [HttpPost("products/addcategory")]
        public IActionResult AddCategoryToProduct(Association NewAssociation)
        {

            dbContext.Add(NewAssociation);
            dbContext.SaveChanges();
            int id = NewAssociation.ProductId;

            return RedirectToAction("ViewProduct", new{id=id});
        }

        [HttpGet("categories")]
        public IActionResult ShowCategories()
        {
            ViewModel CategoryVM = new ViewModel()
            {
                AllCategories = dbContext.Categories.ToList()
            };
            return View("Categories", CategoryVM);
        }

        [HttpPost("categories/add")]
        public IActionResult AddCategory(Category NewCategory)
        {
            Category AddCategory = new Category()
            {
                Name = NewCategory.Name
            };
            dbContext.Add(AddCategory);
            dbContext.SaveChanges();
            return RedirectToAction("ShowCategories");
        }

        [HttpGet("categories/{id}")]
        public IActionResult ViewCategory(int id)
        {
            ViewModel ViewThisCategory = new ViewModel()
            {
                AllProducts = dbContext.Products
                .Include(prod => prod.ProductCategories)
                .ThenInclude(ass => ass.Product)
                .Where(p => p.ProductCategories
                .Any(ass => ass.CategoryId == id)== false)
                .ToList(),

                ViewCategory = dbContext.Categories
                    .Include(cat => cat.CategoryProducts)
                    .ThenInclude(prod => prod.Product)
                    .FirstOrDefault(c => c.CategoryId == id)

            };
            return View("ShowCategory", ViewThisCategory);
        }

        [HttpPost("categories/addproduct")]
        public IActionResult AddProductToCategory(Association NewAssociation)
        {
            dbContext.Add(NewAssociation);
            dbContext.SaveChanges();
            int id = NewAssociation.CategoryId;

            return RedirectToAction("ViewCategory", new{id=id});
        }

    }
}
