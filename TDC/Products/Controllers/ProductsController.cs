using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TDC.Products.Models;
using TDCBiz.Biz;
using TDCEntity.Entity;
//using TDC.Products.Models;

namespace TDC.Products.Controllers
{

    public class ProductsController : Controller
    {

        public ActionResult Index()
        {
            ViewBag.Title = "Index";
            return View();
        }

        [HttpGet]
        public ActionResult GetProductList()
        {
            return View();
        }

        [HttpGet]
        public ActionResult NewProduct()
        {
            return View();
        }

        [HttpPost]
        public ActionResult NewProduct(ProductViewModel pProductViewModel)
        {

            IProductBiz productBiz = TDCBiz.Biz.ProductFactory.GetProductBiz();

            if (productBiz.IsValidVlPrice(pProductViewModel.VlPrice))
            {
                ModelState.AddModelError("CustomError", "Valor inválido!");
            }            

            if (ModelState.IsValid)
            {
                productBiz.InsertProduct(new Product() { IdProduct = pProductViewModel.IdProduct, NmProduct = pProductViewModel.NmProduct, VlPrice = pProductViewModel.VlPrice });
                return RedirectToAction("GetProductList");
            }

            return View(pProductViewModel);

        }
    }
        
}