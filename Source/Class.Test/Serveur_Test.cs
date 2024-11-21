using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Class.Test
{
    [TestClass]
    public class Serveur_Test
    {
        [TestMethod]
        public void Test_GetRang()
        {
            //Arrange
            Serveur Lucas = new Serveur("Dupont", "Lucas");
            ChefRang Henry = new ChefRang ("Dupont", "Lucas");
            Table[] Liste= new Table[3] ;

            Rang Expected_Rang = new Rang(Lucas, Henry, Liste);
            //Le rang d'une variable est defini a la construction d'un objet Rang ; Null sinon


            //Action
            Rang Actual_Rang = Lucas.GetRang();

            //Assert
            Assert.AreEqual(Expected_Rang, Actual_Rang);

        }

        [TestMethod]
        public void Test_SetRang()
        {
            //Arrange
            Serveur Lucas = new Serveur("Dupont", "Lucas");
            Serveur Thomas = new Serveur("Dupont", "Thomas");
            ChefRang Henry = new ChefRang("Dupont", "Lucas");
            Table[] Liste = new Table[3];
            Table[] Liste2 = new Table[4];

            Rang Rang = new Rang(Lucas, Henry, Liste);
            Rang Expected_Rang = new Rang(Thomas, Henry, Liste2);
            //Rang qui n'affecte pas Lucas

            //Action
            Lucas.SetRang(Expected_Rang);

            //Assert
            Assert.AreEqual(Expected_Rang, Lucas.GetRang());
        }

        [TestMethod]
        public void Test_AmenerSucre()
        {
            //
        }

        [TestMethod]
        public void Test_AmenerSale()
        {
            //
        }

        [TestMethod]
        public void Test_Addition()
        {
            //
        }
    }
}
