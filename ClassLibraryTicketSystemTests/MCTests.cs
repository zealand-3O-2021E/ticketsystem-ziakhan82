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
    public class MCTests
    {

        [TestMethod()]
        public void PriceTest()
        {
            //Arrange
            DateTime date = new DateTime(2021,9,27);
            MC mc = new MC("6",date);


            //act

            var price = mc.Price();

            //assert
            Assert.AreEqual(125, price);

            
        }

        [TestMethod()]
        public void VehicleTest()
        {
            DateTime date = new DateTime(2021,9,27);
            //arrange
            MC mc = new MC("6",date);

            //act
            var vehicle = mc.VehicleType();

            //assert
            Assert.AreEqual("MC", vehicle);

            
        }
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void plateException()
        {
            //Arrange
            DateTime dateTime = new DateTime(2021, 09, 27);
            MC car = new MC("1-ABC-12",dateTime);
            //act
           Assert.Fail();
        }
    }
}