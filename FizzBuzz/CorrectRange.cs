using FizzBuzz_Practice;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class CorrectRange
    {
        [TestMethod]
        public void Error_Message_on_input_301()
        {
            //Arrange
            int input = 301;
            StringList TestObj = new StringList();
            //Act
            var result = TestObj.InRange(input);
            //Assert
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void Error_Message_on_input_0()
        {
            //Arrange
            int input = 0;
            StringList TestObj = new StringList();
            //Act
            var result = TestObj.InRange(input);
            //Assert
            Assert.AreEqual(false, result);
        }
    }
}
