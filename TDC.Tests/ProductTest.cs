using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDCBiz.Biz;
using TDCEntity.Entity;
using TDC.Products.Controllers;
using TDC.Products.Models;
using System.Web.Mvc;

namespace TDC.Tests
{
    [TestClass]
    public class ProductTest
    {
        [TestMethod]
        public void GetProductListBiz()
        {
            IProductBiz productBiz = TDCBiz.Biz.ProductFactory.GetProductBiz();

            ProductList productList = productBiz.GetProductList();

            Assert.IsNotNull(productList);

            Assert.AreNotEqual(0, productList.Count);
        }


        [TestMethod]
        public void InsertProductController()
        {
            ProductsController productsController = new ProductsController();

            IProductBiz productBiz = TDCBiz.Biz.ProductFactory.GetProductBiz();

            productBiz.DeleteProductByIdProduct(999); //remove o produto se existir, 

            Product product = productBiz.GetProductByIdProduct(999);

            Assert.IsNull(product); //como removeu, deve ser nulo 

            productsController.NewProduct(new ProductViewModel() { IdProduct = 999, NmProduct = "Teste 999", VlPrice = 9990 });

            product = productBiz.GetProductByIdProduct(999);

            Assert.IsNotNull(product); 

            //após inserir, valida os valores enviados
            Assert.AreEqual(999, product.IdProduct);
            Assert.AreEqual("Teste 9999", product.NmProduct);
            Assert.AreEqual(9990, product.VlPrice);
        }

        [TestMethod]
        public void Index()
        {
            ProductsController controller = new ProductsController();

            ViewResult result = controller.Index() as ViewResult;

            Assert.IsNotNull(result);
            Assert.AreEqual("Index", result.ViewBag.Title);
        }
    }
}
