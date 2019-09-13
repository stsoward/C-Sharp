using FizzBuzz_Practice;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzzTests
{
    [TestClass]
    public class CorrectStringOnInput
    {
        StringList TestObj = new StringList();
        int input;

        [TestMethod]
        public void Returns_1_on_1_input()
        {
            //Given I have a user input of 1
            input = 1;
            //When I call TestObj.NumList()
            var result = TestObj.NumList(input);
            //Then TestObj.NumList() will return 1
            Assert.AreEqual("1", result);
        }

        [TestMethod]
        public void Returns_correct_on_2_input()
        {
            //Given I have a user input of 2
            input = 2;
            //When I call TestObj.NumList()
            var result = TestObj.NumList(input);
            //Then TestObj.NumList() will return 1,2
            Assert.AreEqual("1,2", result);
        }

        [TestMethod]
        public void Returns_correct_on_3_input()
        {
            //Given I have a user input of 3
            input = 3;
            //When I call TestObj.NumList()
            var result = TestObj.NumList(input);
            //Then TestObj.NumList() will return a string ending in Fizz
            Assert.IsTrue(result.EndsWith("Fizz"));      
        }

        [TestMethod]
        public void Returns_correct_on_5_input()
        {
            //Given I have a user input of 5
            input = 5;
            //When I call TestObj.NumList()
            var result = TestObj.NumList(input);
            //Then TestObj.NumList() will return a string ending in Buzz
            Assert.IsTrue(result.EndsWith("Buzz"));
        }

        [TestMethod]
        public void Returns_correct_on_6_input()
        {
            //Given I have a user input of 6
            input = 6;
            //When I call TestObj.NumList()
            var result = TestObj.NumList(input);
            //Then TestObj.NumList() will return a string ending in Fizz
            Assert.IsTrue(result.EndsWith("Fizz"));
        }

        [TestMethod]
        public void Returns_correct_on_10_input()
        {
            //Given I have a user input of 10
            input = 10;
            //When I call TestObj.NumList()
            var result = TestObj.NumList(input);
            //Then TestObj.NumList() will return a string ending in Buzz
            Assert.IsTrue(result.EndsWith("Buzz"));
        }

        [TestMethod]
        public void Returns_correct_on_15_input()
        {
            //Given I have a user input of 15
            input = 15;
            //When I call TestObj.NumList()
            string result = TestObj.NumList(input);
            //Then TestObj.NumList() will return a string ending in FizzBuzz
            Assert.IsTrue(result.EndsWith("FizzBuzz"));
        }

        [TestMethod]
        public void Returns_correct_on_300_input()
        {
            //Given I have a user input of 300
            input = 300;
            //When I call TestObj.NumList()
            string result = TestObj.NumList(input);
            //Then TestObj.NumList() will return a string ending in FizzBuzz
            Assert.IsTrue(result.EndsWith("FizzBuzz"));
        }
    }
}
