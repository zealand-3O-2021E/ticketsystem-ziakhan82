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

            MC mc = new MC();

            //act

            var price = mc.Price();

            //assert
            Assert.AreEqual(125, price);

            
        }

        [TestMethod()]
        public void VehicleTest()
        {
            //arrange
            MC mc = new MC();

            //act
            var vehicle = mc.Vehicle();

            //assert
            Assert.AreEqual("MC", vehicle);
        }
    }
}