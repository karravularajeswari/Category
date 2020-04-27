using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCPractice.Models
{
    public class Product
    {
        public int Pid { get; set; }
        public String Pname { get; set; }
        public Double Pprice { get; set; }
        public string photo { get; set; }
        public int Cat_Cid { get; set; }
    }
}