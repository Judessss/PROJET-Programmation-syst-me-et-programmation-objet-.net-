using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Class.Test
{
    [TestClass]
    public class Carre_Test
    {
        [TestMethod]
        public void Test_GetRangUn()
        {
            //Arrange
            // Rang 1
            Serveur Serveur_Rang1 = new Serveur("Dupont", "Lucas");
            ChefRang CR_Rang1 = new ChefRang("Pascal", "Henry");
            Table[] Liste_Rang1 = new Table[3];
            Rang Expected_Rang = new Rang(Serveur_Rang1, CR_Rang1, Liste_Rang1);
            
            //Rang2
            Serveur Serveur_Rang2 = Serveur_Rang1;
            ChefRang ChefRang_Rang2 = CR_Rang1;
            Table[] Liste_Rang2 = Liste_Rang1;
            Rang Rang2 = new Rang(Serveur_Rang2, ChefRang_Rang2, Liste_Rang2);

            Carre Carre = new Carre(Expected_Rang, Rang2);

            //Action
            Rang Actual_Rang = Carre.GetRangUn();

            //Assert
            Assert.AreEqual(Expected_Rang, Actual_Rang);
        }

        [TestMethod]
        public void Test_GetRangDeux()
        {
            //Arrange
            // Rang 1
            Serveur Serveur_Rang1 = new Serveur("Dupont", "Lucas");
            ChefRang CR_Rang1 = new ChefRang("Pascal", "Henry");
            Table[] Liste_Rang1 = new Table[3];
            Rang Rang1 = new Rang(Serveur_Rang1, CR_Rang1, Liste_Rang1);

            //Rang2
            Serveur Serveur_Rang2 = Serveur_Rang1;
            ChefRang ChefRang_Rang2 = CR_Rang1;
            Table[] Liste_Rang2 = Liste_Rang1;
            Rang Expected_Rang = new Rang(Serveur_Rang2, ChefRang_Rang2, Liste_Rang2);

            Carre Carre = new Carre(Rang1, Expected_Rang);

            //Action
            Rang Actual_Rang = Carre.GetRangDeux();

            //Assert
            Assert.AreEqual(Expected_Rang, Actual_Rang);
        }

    }
}
