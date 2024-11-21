using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Class.Test
{
    [TestClass]
    public class Commisalle_Test
    {
        [TestMethod]
        public void Test_GetInstance()
        {
            //Assert
            Assert.AreEqual(CommisSalle.GetInstance("",""), CommisSalle.GetInstance());
                
        }
        /*
        [TestMethod]
        public void Test_Debarasse()
        { 
            //
        }

        [TestMethod]
        public void Test_AmenerEau()
        {
            //
        }

        [TestMethod]
        public void Test_AmenerPain()
        {
            //
        }

        [TestMethod]
        public void Test_DresserTable()
        {
            //
        }*/
    }
}
