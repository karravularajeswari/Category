using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCPractice.Models
{
    public class DataLayer
    {
        public IEnumerable<Category> CategoriesData
        {
            get
            {
                List<Category> categories = new List<Category>()
                {
                    new Category{Cid=1,Cname="Electronics"},
                    new Category{Cid=2,Cname="Shoes"},
                    new Category{Cid=3,Cname="Clothes"}
                };
                return categories;
            }
        }
        public IEnumerable<Product> ProductsData
        {
            get
            {
                List<Product> products = new List<Product>()
                {
                    new Product{Pid=1,Pname="Laptop",Pprice=25000,Cat_Cid=1},
                    new Product{Pid=2,Pname="Nike",Pprice=2000,Cat_Cid=2},
                    new Product{Pid=3,Pname="Dress",Pprice=1500,Cat_Cid=3}
                };
                return products;
            }
        }
    }
}