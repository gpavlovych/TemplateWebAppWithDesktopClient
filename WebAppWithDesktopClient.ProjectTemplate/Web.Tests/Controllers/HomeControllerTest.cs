using System.Web.Mvc;
using FluentAssertions;
using $saferootprojectname$.Web.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ploeh.AutoFixture;

namespace $safeprojectname$.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void About()
        {
            // Arrange
            var fixture = new ControllerAutoFixture();
            var target = fixture.Create<HomeController>();

            // Act
            ViewResult result = target.About() as ViewResult;

            // Assert
            result.ViewData["Message"].Should().Be("Your application description page.");
        }

        [TestMethod]
        public void Contact()
        {
            // Arrange
            var fixture = new ControllerAutoFixture();
            var target = fixture.Create<HomeController>();

            // Act
            ViewResult result = target.Contact() as ViewResult;

            // Assert
            result.ViewData["Message"].Should().Be("Your contact page.");
        }
    }
}
