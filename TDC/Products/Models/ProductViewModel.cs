using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TDC.Products.Models
{
    public class ProductViewModel
    {
        public int IdProduct { get; set; }

        [Required(ErrorMessage = "Digite o nome do produto")]
        public string NmProduct { get; set; }

        public float VlPrice { get; set; }

        public string Message { get; set; }
    }
}