using FluentAssertions;
using $saferootprojectname$.Web.Properties;
using $saferootprojectname$.Web.DAL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ploeh.AutoFixture;

namespace $safeprojectname$.DAL
{
    [TestClass]
    public class SettingsProviderTests
    {
        [TestMethod]
        public void PageSizeTest()
        {
            // arrange
            var fixture = new TestAutoFixture();
            var settings = fixture.Build<Settings>().Create();
            var target = fixture.Create<SettingsProvider>();

            // act
            var result = target.PageSize;

            // assert
            result.Should().Be(settings.PageSize);
        }
    }
}
