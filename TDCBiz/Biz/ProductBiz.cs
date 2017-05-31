using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDCDAL.DAL;
using TDCEntity.Entity;

namespace TDCBiz.Biz
{
    public class ProductBiz : IProductBiz
    {
        private ProductDAL productDAL;
        internal ProductBiz()
        {
            this.productDAL = new ProductDAL();
        }

        public ProductList GetProductList()
        {
            return productDAL.GetProductList();
        }
        public bool IsValidVlPrice(float pVlPrice)
        {
            return pVlPrice > 10000;
        }
        public void InsertProduct(Product pProduct)
        {
            this.productDAL.InsertProduct(pProduct);
        }
        public Product GetProductByIdProduct(int pIdProduct)
        {
            return this.productDAL.GetProductByIdProduct(pIdProduct);
        }
        public void DeleteProductByIdProduct(int pIdProduct)
        {
            this.productDAL.DeleteProductByIdProduct(pIdProduct);
        }
    }
}
