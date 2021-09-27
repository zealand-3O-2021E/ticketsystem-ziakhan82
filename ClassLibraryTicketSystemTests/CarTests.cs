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
            DateTime date = new DateTime(2021, 9, 27);
            // arrange
            Car car = new Car("6", date);

            //act
            var price = car.Price();

            //assert

            Assert.AreEqual(240, price);

        }

        [TestMethod()]
        public void VehicleTypeTest()
        {
            DateTime date = new DateTime(2021, 9, 27);
            //arrange
            Car car = new Car("6", date);

            //act
            var type = car.VehicleType();
            // assert

            Assert.AreEqual("Car", type);
        }
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void plateException()
        {
            //Arrange
            DateTime dateTime = new DateTime(2021, 09, 27);
            Car car = new Car("1-ABC-12", dateTime);
            //act
            Assert.Fail();
        }
    }
}