using CustomersService;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FacadeTest2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetOff_true1()
        {
            // Arrange
            Service con = new Service();

            // Act
            int off = 1;

            // Assert
            con.Ansver(off);
        }

        [TestMethod]
        public void GetOff_true2()
        {
            // Arrange
            Service con = new Service();

            // Act
            int off = 2;

            // Assert
            con.Ansver(off);
        }

        [TestMethod]
        public void GetOff_true3()
        {
            // Arrange
            Service con = new Service();

            // Act
            int off = 3;

            // Assert
            con.Ansver(off);
        }

        [TestMethod]
        public void GetOff_false()
        {
            // Arrange
            Service con = new Service();

            // Act
            int off = 6;

            // Assert
            Assert.ThrowsException<Exception>(() => con.Ansver(off));
        }
    }
}
