using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Class.Test
{
    [TestClass]
    public class MaitreHotel_Test
    {
        [TestMethod]
        public void Test_GetInstance()
        {

            //Assert
            Assert.AreEqual(MaitreHotel.GetInstance("DUPONT", "Leon"), MaitreHotel.GetInstance());

        }

        /*[TestMethod]
        public void Test_AttribueTable()
        {
            //
        }

        [TestMethod]
        public void Test_AttribueTable()
        {
            //
        }*/
    }
}
