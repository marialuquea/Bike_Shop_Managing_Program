using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SEM_cw2;

namespace TestingClasses
{
    [TestClass]
    public class UnitTest1
    {
        //the bike object to test
        Bike bike = new Bike();
        
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void typeTest()
        {
            bike.Type = "hi";
        }

        [TestMethod]
        public void typeTest2()
        {
            bike.Type = "small";
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void wheelTest()
        {
            bike.Wheels = "asdasd";
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void sizeTest()
        {
            bike.Wheels = "asdsad";
        }

    }
}
