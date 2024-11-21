using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Class.Test
{
    [TestClass]
    public class Reservation_Test
    {
        [TestMethod]
        public void Test_GetReserved()
        {
            //Arrange
            Table Table = new Table(4, 4);
            //une table 
            Boolean Expected = false;          
            Reservation Reservation = new Reservation(Expected, Table, false);

            //Action
            Boolean Actual = Reservation.GetReserved();

            //Assert
            Assert.AreEqual(Expected,Actual);             
        }

        [TestMethod]
        public void Test_SetReserved()
        {
            //Arrange
            Table Table = new Table(4, 4);
            Reservation Reservation = new Reservation(false, Table, false);
            Boolean Expected = true;
            //Action
            Reservation.SetReserved(Expected);

            //Assert
            Assert.AreEqual(Expected, Reservation.GetReserved());
        }

        
        [TestMethod]
        public void Test_GetTable()
        {
            //Arrange
            Table Expected_Table = new Table(4, 4);
            //une table      
            Reservation Reservation = new Reservation(false, Expected_Table, false);

            //Action
            Table Actual_Table = Reservation.GetTable();

            //Assert
            Assert.AreEqual(Expected_Table, Actual_Table);    
        }

        [TestMethod]
        public void Test_SetTable()
        {
            //Arrange
            Table Table = new Table(4, 4);
            Reservation Reservation = new Reservation(false, Table, false);
            Table Expected_Table = new Table(6,5);

            //Action
            Reservation.SetTable(Expected_Table);

            //Assert
            Assert.AreEqual(Expected_Table, Reservation.GetTable());
        }

        [TestMethod]
        public void Test_GetMatin()
        {
            //Arrange
            Table Table = new Table(4, 4);
            //une table 
            Boolean Expected_Matin = false;
            Reservation Reservation = new Reservation(false, Table, Expected_Matin);

            //Action
            Boolean Actual_Matin = Reservation.GetMatin();

            //Assert
            Assert.AreEqual(Expected_Matin, Actual_Matin);
        }

        [TestMethod]
        public void Test_SetMatin()
        {
            //Arrange
            Table Table = new Table(4, 4);
            Reservation Reservation = new Reservation(false, Table, false);
            Boolean Expected = true;
            //Action
            Reservation.SetMatin(Expected);

            //Assert
            Assert.AreEqual(Expected, Reservation.GetMatin());
        }

        /*[TestMethod] NON REALISE
        public void Test_GetDate()
        {

        }*/
    }
}
