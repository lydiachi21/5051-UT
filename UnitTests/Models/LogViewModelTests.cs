using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HW1c.Models;

namespace UnitTests.Models
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void LogViewModel_Instantiate_Deault_Should_Pass()
        {
            //Arrange


            //Act
            var result = new LogViewModel();

            //Assert
            Assert.IsNotNull(result);
        }
    }
}
