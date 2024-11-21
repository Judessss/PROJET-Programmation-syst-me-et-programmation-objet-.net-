using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Class.Test
{
    [TestClass]
    public class PersonnelCuisine_Test
    {
        [TestMethod]
        public void Test_GetNom()
        {
            //Arrange
            String Expected_Nom = "Dupont";
            PersonnelCuisine Employe = new PersonnelCuisine(Expected_Nom, "Lucas");

            //Action
            String Actual_Nom = Employe.GetNom();

            //Assert
            Assert.AreEqual(Expected_Nom, Actual_Nom);
        }

        [TestMethod]
        public void Test_GetPrenom()
        {
            //Arrange
            String Expected_Prenom = "Lucas";
            PersonnelCuisine Employe = new PersonnelCuisine("Dupont", Expected_Prenom);

            //Action
            String Actual_Prenom = Employe.GetPrenom();

            //Assert
            Assert.AreEqual(Expected_Prenom, Actual_Prenom);
        }

        [TestMethod]
        public void Test_GetIsBusy()
        {
            //Arrange
            Boolean Expected_State = false;
            //Valeur par defaut
            PersonnelCuisine Employe = new PersonnelCuisine("Dupont", "Lucas");

            //Action
            Boolean Actual_State = Employe.GetIsBusy();

            //Assert
            Assert.AreEqual(Expected_State, Actual_State);
        }

        [TestMethod]
        public void Test_SetIsBusy()
        {
            //Arrange
            Boolean Expected_State = true;
            //Valeur par defaut
            PersonnelCuisine Employe = new PersonnelCuisine("Dupont", "Lucas");

            //Action
            Employe.SetIsBusy(Expected_State);

            //Assert
            Assert.AreEqual(Expected_State, Employe.GetIsBusy());
        }

    }
}
