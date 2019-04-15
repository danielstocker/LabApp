using LabApp.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LabApp.Tests
{
    [TestClass]
    public class HomeControllerTests
    {
        [TestMethod]
        public void Index()
        {
            var controller = new HomeController();
            controller.Index();
            Assert.IsNotNull(controller);
            Assert.IsTrue(controller.ViewData.Values.Count == 0);
        }

        [TestMethod]
        public void About()
        {
            var controller = new HomeController();
            controller.About();
            Assert.IsNotNull(controller);
            Assert.IsTrue(controller.ViewData["Message"].ToString().Contains("description"));
        }

        [TestMethod]
        public void Contact()
        {
            var controller = new HomeController();
            controller.Contact();
            Assert.IsNotNull(controller);
            Assert.IsTrue(controller.ViewData["Message"].ToString().Contains("contact"));
        }
    }
}
