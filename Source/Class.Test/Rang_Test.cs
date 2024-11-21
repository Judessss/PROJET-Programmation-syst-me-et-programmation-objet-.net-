using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Class.Test
{
    [TestClass]
    public class Rang_Test
    {
        [TestMethod]
        public void Test_GetServeur()
        {
            //Arrange
            Serveur Expected_Serveur = new Serveur ("Dupont", "Lucas");
            ChefRang ChefRang = new ChefRang("Pascal", "Henry");
            Table[] Liste = new Table[3] ;
            Rang Rang = new Rang(Expected_Serveur, ChefRang, Liste);

            //Action
            Serveur Actual_Serveur = Rang.GetServeur();

            //Assert
            Assert.AreEqual(Expected_Serveur, Actual_Serveur);
        }

        [TestMethod]
        public void Test_GetChefRang()
        {
            //Arrange
            Serveur Serveur = new Serveur("Dupont", "Lucas");
            ChefRang Expected_ChefRang = new ChefRang("Pascal", "Henry");
            Table[] Liste = new Table[3];
            Rang Rang = new Rang(Serveur, Expected_ChefRang, Liste);

            //Action
            ChefRang Actual_ChefRang = Rang.GetChefRang();

            //Assert
            Assert.AreEqual(Expected_ChefRang, Actual_ChefRang);

        }

        [TestMethod]
        public void GetListeTables()
        {
            //Arrange
            Serveur Serveur = new Serveur("Dupont", "Lucas");
            ChefRang ChefRang = new ChefRang("Pascal", "Henry");
            Table[] Expected_Liste = new Table[3];
            Rang Rang = new Rang(Serveur, ChefRang, Expected_Liste);

            //Action
            Table[] Actual_Liste = Rang.GetListeTables();

            //Assert
            Assert.AreEqual(Expected_Liste, Actual_Liste);
        }
    }
}
