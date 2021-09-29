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
    public class OresundCarTests
    {
        [TestMethod()]
        public void OresundCarTest()
        {
            // arrange


        }

        [TestMethod()]
        public void PriceTest()
        {
            //Arrange
            DateTime date = new DateTime(2021, 09, 28);
            //Act
            OresundCar oresundCar = new OresundCar("6", date);
            var result = oresundCar.Price(true);
            //Assert
            Assert.AreEqual(161, result);


        }

        [TestMethod()]
        public void VehicleTypeTest()
        {
            DateTime date = new DateTime(2021, 9, 27);
            //arrange
            OresundCar oresundCar = new OresundCar("6", date);

            //act
            var type = oresundCar.VehicleType();
            // assert

            Assert.AreEqual("OresundCar", type);

        }
    }
}