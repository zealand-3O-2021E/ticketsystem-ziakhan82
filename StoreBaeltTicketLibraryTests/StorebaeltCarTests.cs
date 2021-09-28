using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework.Internal;
using StoreBaeltTicketLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StoreBaeltTicketLibrary.Tests
{
    [TestClass()]
    public class StorebaeltCarTests
    {
       
        [TestMethod()]
        public void StorebaeltCarTest()
        {

            //Assert.Fail();
        }

        [TestMethod()]
        public void PriceTest()
        {
            DateTime date = new DateTime(2021, 9, 27);
            StorebaeltCar storebaeltCar = new StorebaeltCar("6", date);
          var result=  storebaeltCar.Price(true);
            Assert.AreEqual(228, result);

        }
    }
}