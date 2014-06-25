using CycleSalesPublicSite.Controllers;
using CycleSalesPublicSite.Models;
using EntityFramework.Testing.Moq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace CycleSalesPublicSite.Test.Controllers
{
    [TestClass]
    public class BikesControllerTest
    {
        [TestMethod]
        public void Index_shows_most_expensive_first()
        {
            // Arrange
            var testData = new List<Bike>
            {
                new Bike { Retail = 100M },
                new Bike { Retail = 200M },
                new Bike { Retail = 50M }
            };

            // TODO Setup a mock context




            // Act
            var controller = new BikesController(/* TODO Pass in mock context*/);
            var result = controller.Index() as ViewResult;

            // Assert
            var bikes = result.Model as IEnumerable<Bike>;
            Assert.AreEqual(200M, bikes.First().Retail);
        }
    }
}
