using FizzBuzz_Practice;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzzTests
{
    [TestClass]
    public class CorrectResultOnInput
    {
        StringList TestObj = new StringList();
        int input;

        [TestMethod]
        public void Returns_1_on_1_input()
        {
            //Arrange
            input = 1;            
            //Act
            var result = TestObj.NumList(input);
            //Assert
            Assert.AreEqual("1", result);
        }

        [TestMethod]
        public void Returns_correct_on_2_input()
        {
            //Arrange
            input = 2;
            //Act
            var result = TestObj.NumList(input);
            //Assert
            Assert.AreEqual("1,2", result);
        }

        [TestMethod]
        public void Returns_correct_on_3_input()
        {
            //Arrange
            input = 3;
            //Act
            var result = TestObj.NumList(input);
            //Assert
            Assert.IsTrue(result.EndsWith("Fizz"));      
        }

        [TestMethod]
        public void Returns_correct_on_5_input()
        {
            //Arrange
            input = 5;
            //Act
            var result = TestObj.NumList(input);
            //Assert
            Assert.IsTrue(result.EndsWith("Buzz"));
        }

        [TestMethod]
        public void Returns_correct_on_6_input()
        {
            //Arrange
            input = 6;
            //Act
            var result = TestObj.NumList(input);
            //Assert
            Assert.IsTrue(result.EndsWith("Fizz"));
        }

        [TestMethod]
        public void Returns_correct_on_10_input()
        {
            //Arrange
            input = 10;
            //Act
            var result = TestObj.NumList(input);
            //Assert
            Assert.IsTrue(result.EndsWith("Buzz"));
        }

        [TestMethod]
        public void Returns_correct_on_15_input()
        {
            //Arrange
            input = 15;
            //Act
            string result = TestObj.NumList(input);
            //Assert
            Assert.IsTrue(result.EndsWith("FizzBuzz"));
        }

        [TestMethod]
        public void Returns_correct_on_300_input()
        {
            //Arrange
            input = 300;
            //Act
            string result = TestObj.NumList(input);
            //Assert
            Assert.IsTrue(result.EndsWith("FizzBuzz"));
        }
    }
}
