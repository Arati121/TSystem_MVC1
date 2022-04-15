using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TSystem_MVC1.Models;


namespace TSystem_MVC1.Models
{
    public enum Gender { Male, Female }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public decimal Price { get; set; }
    }
}
