using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Notes.WebAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Web.Resource;

namespace Notes.WebAPI.Controllers.Tests
{
    [TestClass()]
    public class WeatherForecastControllerTests
    {
        private WeatherForecastController weatherForecastController;
        private Mock<HttpContext> httpContext;

        [TestInitialize()]
        public void Initialize()
        {
            var mockLogger = new Mock<ILogger<WeatherForecastController>>();
            weatherForecastController = new WeatherForecastController(mockLogger.Object);
            httpContext = new Mock<HttpContext>();
            weatherForecastController.ControllerContext = new ControllerContext();
            weatherForecastController.ControllerContext.HttpContext = httpContext.Object;
        }

        [TestMethod()]
        public void GetRequestTest()
        {
            var result = weatherForecastController.Get();

            Assert.IsTrue(result?.Count() > 0);
        }
    }
}