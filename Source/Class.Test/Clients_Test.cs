using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Class.Test
{
    [TestClass]
    public class Clients_Test
    {
        [TestMethod]
        public void Test_GetNBCLients()
        {
            //Arrange
            int Expected_NBclients = 4;
            String[] CMD = null;
            Clients Client_Test = new Clients(Expected_NBclients, false, "", CMD);

            //Action
            int Actual_NBClients = Client_Test.GetNBClients();

            //Assert
            Assert.AreEqual(Actual_NBClients, Expected_NBclients);
        }

        [TestMethod]
        public void Test_GetCommandes()
        {
            //Arrange
            String[] Expected_CMD = {"AA", "BB"};
            Clients Client_Test = new Clients(4, false, "", Expected_CMD);

            //Action
            String[] Actual_CMD = Client_Test.GetCommandes();

            //Assert
            Assert.AreEqual(Actual_CMD, Expected_CMD);
        }

    }
}
