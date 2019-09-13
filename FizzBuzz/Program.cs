using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz_Practice
{

    public class StringList
    {
        //Returns a FizzBuzz string
        public string NumList(int input)
        {
            string result = "1";
            if(input == 1)
            {
                return result;
            }
            for (int i = 2; i <= input; i++)
            {
                result += ",";
                if (i % 3 == 0)
                {
                    result += "Fizz";
                }
                if (i % 5 == 0)
                {
                    result += "Buzz";
                }
                if (i % 3 != 0 && i % 5 != 0)
                {
                    result += i.ToString();
                }
            }
            return result;
        }

        //Checks if int is in range 1-300
        public bool InRange(int input)
        {
            if (input > 300 || input < 1)
            {
                Console.WriteLine("Please enter a number between 1 and 300");
                return false;
            }
            return true;
        }

        public static void Main()
        {
            StringList TestObj = new StringList();
            int UserInput;
            string ReadLine;
            Console.WriteLine("Press 'q' at any time to quit");
            while (true)
            {
                Console.WriteLine("Enter your number (1-300):");
                ReadLine = Console.ReadLine();
                if (ReadLine == "q")
                {
                    break;
                }
                int.TryParse(ReadLine, out UserInput);
                if (TestObj.InRange(UserInput))
                {
                    Console.WriteLine(TestObj.NumList(UserInput));
                }
            }
        }
}
}
