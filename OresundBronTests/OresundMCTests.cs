using Microsoft.VisualStudio.TestTools.UnitTesting;
using OresundBron;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OresundBron.Tests
{
    [TestClass()]
    public class OresundMCTests
    {
        [TestMethod()]
        public void OresundMCTest()
        {
           
        }

        [TestMethod()]
        public void PriceTest()
        {
            //Arrange
            DateTime date = new DateTime(2021, 09, 28);
            //Act
            OresundMC oresundMC = new OresundMC("6", date);
            var result = oresundMC.Price(false);
            //Assert
            Assert.AreEqual(210, result);

        }

        [TestMethod()]
        public void VehicleTypeTest()
        {
            DateTime date = new DateTime(2021, 9, 27);
            //arrange
            OresundMC oresundMC = new OresundMC("6", date);

            //act
            var type = oresundMC.VehicleType();
            // assert

            Assert.AreEqual("Oresund MC", type);

        }
    }
}