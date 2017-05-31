using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDCDAL.DAL;
using TDCEntity.Entity;

namespace TDCBiz.Biz
{
    public interface IProductBiz
    {
        ProductList GetProductList();

        bool IsValidVlPrice(float pVlPrice);
        void InsertProduct(Product pProduct);
        Product GetProductByIdProduct(int pIdProduct);
        void DeleteProductByIdProduct(int pIdProduct);

    }
}
