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
        public void False_return_on_input_301()
        {
            //Given I have a user input of 301
            input = 301;
            //When I call TestObj.InRange()
            var result = TestObj.InRange(input);
            //Then TestObj.InRanget() will return false
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void False_return_on_input_0()
        {
            //Given I have a user input of 0
            input = 0;
            //When I call TestObj.InRange()
            var result = TestObj.InRange(input);
            //Then TestObj.InRanget() will return false
            Assert.AreEqual(false, result);
        }
    }
}
