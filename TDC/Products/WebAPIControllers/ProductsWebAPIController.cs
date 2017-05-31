using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using TDCBiz.Biz;
using TDCEntity.Entity;
//using TDC.Products.Models;

namespace TDC.Products.WebAPIControllers
{

    public class ProductsWebAPIController : ApiController
    {
        IProductBiz productBiz = TDCBiz.Biz.ProductFactory.GetProductBiz();

        public ProductList GetProductList()
        {
            return productBiz.GetProductList();
        }
    }


}