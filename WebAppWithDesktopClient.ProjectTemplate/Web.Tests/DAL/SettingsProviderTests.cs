// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SettingsProviderTests.cs" company="">
//   
// </copyright>
// <summary>
//   TODO The settings provider tests.
// </summary>
// --------------------------------------------------------------------------------------------------------------------



using FluentAssertions;
using $saferootprojectname$.Web.Properties;
using $saferootprojectname$.Web.DAL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ploeh.AutoFixture;

namespace $safeprojectname$.DAL
{
    /// <summary>TODO The settings provider tests.</summary>
    [TestClass]
    public class SettingsProviderTests
    {
        /// <summary>TODO The page size test.</summary>
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
