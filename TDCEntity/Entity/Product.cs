using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDCEntity.Entity
{
    public class Product
    {
        public int IdProduct { get; set; }

        public string NmProduct { get; set; }

        public float VlPrice { get; set; }

        public DateTime DtRegister { get; set; } 
    }

    public class ProductList : List<Product>
    {

    }
}
