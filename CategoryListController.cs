using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCPractice.Models;

namespace MVCPractice.Controllers
{
    public class CategoryListController : Controller
    {
        // GET: CategoryList
        DataLayer dl = new DataLayer();
        public ViewResult CatList()
        {
            return View(dl.CategoriesData);
        }
        public ViewResult CatDetails(int id)
        {
            return View(dl.CategoriesData.Single(x => x.Cid == id));
        }

        
    }
}