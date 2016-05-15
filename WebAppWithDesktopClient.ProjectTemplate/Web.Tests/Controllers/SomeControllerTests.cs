using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using $saferootprojectname$.Web.Controllers;
using Ploeh.AutoFixture;

namespace $safeprojectname$.Controllers
{
    [TestClass]
    public class SomeControllerTests
    {
        [TestMethod]
        public void IndexTest()
        {
            // Arrange
            var fixture = new ControllerAutoFixture();
            var target = fixture.Create<SomeController>();
            
            // Act
            var result = target.Index() as ViewResult;
            
            // Assert
            Assert.IsNotNull(result);
        }
    }
}
