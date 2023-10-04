using conveer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FacadeTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetAvt_true1()
        {
            // Arrange
            Conveer con = new Conveer();

            // Act
            int avt = 1;

            // Assert
            con.Sborka(avt);
        }

        [TestMethod]
        public void GetAvt_true2()
        {
            // Arrange
            Conveer con = new Conveer();

            // Act
            int avt = 2;

            // Assert
            con.Sborka(avt);
        }

        [TestMethod]
        public void GetAvt_true3()
        {
            // Arrange
            Conveer con = new Conveer();

            // Act
            int avt = 3;

            // Assert
            con.Sborka(avt);
        }

        [TestMethod]
        public void GetAvt_false()
        {
            // Arrange
            Conveer con = new Conveer();

            // Act
            int avt = 6;

            // Assert
            Assert.ThrowsException<Exception>(() => con.Sborka(avt));
        }
    }
}

