using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCPractice.Models;

namespace MVCPractice.Controllers
{
    public class ProductsListController : Controller
    {
        // GET: ProductsList
        DataLayer dd = new DataLayer();
        public ViewResult ProdList(int id)
        {
            return View(dd.ProductsData.Where(x=>x.Cat_Cid==id).ToList());
        }
        public ViewResult ProdDetails(int id)
        {
            return View(dd.ProductsData.Single(x => x.Pid == id));
        }
        
    }
}