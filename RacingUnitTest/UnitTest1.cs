using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RacingAssessment;

namespace RacingUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestRandom()
        {
            //instantiate a new form
            Form1 myForm = new Form1();
            //run the method on the form and then pass the message to a variable for testing
            var randNum = myForm.RandomGenerator();
            //is the generated error message showing what it should?
            Assert.IsTrue((randNum.Next(1,5) > 0) && (randNum.Next(1,5) < 6));
        }
    }
}
