using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDCDAL.DAL;
using TDCEntity.Entity;

namespace TDCBiz.Biz
{
    public static class ProductFactory
    {
        public static ProductBiz GetProductBiz()
        {
            //adicionar "if", para condição para criar classe "Mock"
            return new ProductBiz();
        }
         
    }
}
