using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibraryTicketSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem.Tests
{
    [TestClass()]
    public class CarTests
    {
        [TestMethod()]
        public void PriceTest()
        {
            // arrange
            Car car = new Car();

            //act
            var price = car.Price();

            //assert

            Assert.AreEqual(240, price);
           
        }

        [TestMethod()]
        public void VehicleTypeTest()
        {

            //arrange
            Car car = new Car();

            //act
            var type = car.VehicleType();
            // assert

            Assert.AreEqual("Car", type);
        }
    }
}