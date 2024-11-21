using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Class.Test
{
    [TestClass]
    public class Commande_Test
    {
        [TestMethod]
        public void Test_GetTable()
        {
            //Arrange
            Table Expected_Table = new Table(4, 4);
            Commande CMD = new Commande(Expected_Table, "Pates");

            //Action
            Table Actual_Table = CMD.GetTable();


            //Assert
            Assert.AreEqual(Expected_Table, Actual_Table);

        }

        [TestMethod]
        public void Test_GetPlats()
        {
            //Arrange
            Table Table = new Table(4, 4);
            String Expected_Plat = "Pates";
            Commande CMD = new Commande(Table, Expected_Plat);

            //Action
            String Actual_Plat = CMD.GetPlats();

            //Assert
            Assert.AreEqual(Expected_Plat, Actual_Plat);
        }

        [TestMethod]
        public void Test_SetPlats()
        {
            //Arrange
            Table Table = new Table(4, 4);
            String Expected_Plat = "Pates";
            Commande CMD = new Commande(Table, "Pizza");

            //Action
            CMD.SetPlats(Expected_Plat);

            //Assert
            Assert.AreEqual(Expected_Plat, CMD.GetPlats());
        }


    }
}
