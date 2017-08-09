using GabrielStefan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GabrielStefan.Controllers
{
    public class CategoriesController : Controller
    {
        private static IList<Category> categoryList =
            new List<Category>()
            {
                new Category() {CategoryId = 1, Name = "Keyboard"},
                new Category() {CategoryId = 2, Name = "Monitor"},
                new Category() {CategoryId = 3, Name = "Notebook"},
                new Category() {CategoryId = 4, Name = "Mouse"},
                new Category() {CategoryId = 5, Name = "Printer"}
            };

        // GET: Categores
        public ActionResult Index()
        {
            return View(categoryList.OrderBy(c => c.Name));
        }
        //SELETC *
        //FROM categories
        // ORFER BY name
        /*
         * (c => c.Name)
         *
        private String Name(Category c)
        {
            return c.Name;
        }
        */
    }
}