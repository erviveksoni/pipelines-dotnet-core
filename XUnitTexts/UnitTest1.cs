using System;
using Microsoft.AspNetCore.Mvc;
using dotnetcore_sample.Controllers;
using Xunit;

namespace XUnitTexts
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.About() as ViewResult;

            // Assert
            Assert.Equal("Your application description page.", result.ViewData["Message"]);

        }
    }
}
