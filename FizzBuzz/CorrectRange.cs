using FizzBuzz_Practice;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzzTests
{
    [TestClass]
    public class CorrectRange
    {
        StringList TestObj = new StringList();
        int input;

        [TestMethod]
        public void Error_Message_on_input_301()
        {
            //Arrange
            input = 301;
            //Act
            var result = TestObj.InRange(input);
            //Assert
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void Error_Message_on_input_0()
        {
            //Arrange
            input = 0;
            //Act
            var result = TestObj.InRange(input);
            //Assert
            Assert.AreEqual(false, result);
        }
    }
}
