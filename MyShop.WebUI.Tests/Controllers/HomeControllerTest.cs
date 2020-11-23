using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyShop.Core.Contracts;
using MyShop.Core.Models;
using MyShop.Core.ViewModels;
using MyShop.WebUI.Tests.Controllers;
using MyShop.WebUI.Controllers;
using System;
using System.Linq;
using System.Web.Mvc;
using MyShop.WebUI.Tests.Controllers.Mocks;

namespace MyShop.WebUI.Tests.Controllers
{
    [TestClass]
    public class UnitTest1
    {
        //check if page returns product 
        [TestMethod]
        public void IndexPageDoesReturnProducts()
        {
            IRepository<Product> productContext = new Mocks.MockContext<Product>();
            IRepository<ProductCategory> productCategoryContext = new Mocks.MockContext<ProductCategory>();
            HomeController controller = new HomeController(productContext, productCategoryContext);

            productContext.Insert(new Product());

            var result = controller.Index() as ViewResult;
            var viewModel = (ProductListViewModel)result.ViewData.Model;

            Assert.AreEqual(1, viewModel.Products.Count());
        }
    }
}