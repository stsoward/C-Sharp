using FizzBuzz_Practice;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzzTests
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void Returns_1_on_1_input()
        {
            //Arrange
            int input = 1;
            StringList TestObj = new StringList();
            //Act
            var result = TestObj.NumList(input);
            //Assert
            Assert.AreEqual("1", result);
        }

        [TestMethod]
        public void Returns_correct_on_2_input()
        {
            //Arrange
            int input = 2;
            StringList TestObj = new StringList();
            //Act
            var result = TestObj.NumList(input);
            //Assert
            Assert.AreEqual("1,2", result);
        }

        [TestMethod]
        public void Returns_correct_on_3_input()
        {
            //Arrange
            int input = 3;
            StringList TestObj = new StringList();
            //Act
            var result = TestObj.NumList(input);
            //Assert
            Assert.IsTrue(result.EndsWith("Fizz"));      
        }

        [TestMethod]
        public void Returns_correct_on_5_input()
        {
            //Arrange
            int input = 5;
            StringList TestObj = new StringList();
            //Act
            var result = TestObj.NumList(input);
            //Assert
            Assert.IsTrue(result.EndsWith("Buzz"));
        }

        [TestMethod]
        public void Returns_correct_on_6_input()
        {
            //Arrange
            int input = 6;
            StringList TestObj = new StringList();
            //Act
            var result = TestObj.NumList(input);
            //Assert
            Assert.IsTrue(result.EndsWith("Fizz"));
        }

        [TestMethod]
        public void Returns_correct_on_10_input()
        {
            //Arrange
            int input = 10;
            StringList TestObj = new StringList();
            //Act
            var result = TestObj.NumList(input);
            //Assert
            Assert.IsTrue(result.EndsWith("Buzz"));
        }

        [TestMethod]
        public void Returns_correct_on_15_input()
        {
            //Arrange
            int input = 15;
            StringList TestObj = new StringList();
            //Act
            string result = TestObj.NumList(input);
            //Assert
            Assert.IsTrue(result.EndsWith("FizzBuzz"));
        }

        [TestMethod]
        public void Returns_correct_on_300_input()
        {
            //Arrange
            int input = 300;
            StringList TestObj = new StringList();
            //Act
            string result = TestObj.NumList(input);
            //Assert
            Assert.IsTrue(result.EndsWith("FizzBuzz"));
        }
    }
}
