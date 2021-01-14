using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class APIPerson
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public string gender { get; set; }
    }

    public  class APICar
    { 
        public int year { get; set; }
        public string make { get; set; }
        public int id { get; set; }
        public string model { get; set; }
    }
}
