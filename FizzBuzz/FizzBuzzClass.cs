using System;

namespace FizzBuzz
{
    public class FizzBuzzer
    {
        public string FizzIt(int number)
        {
            var returnString = String.Empty;
            if (number % 3 == 0)
            {
                returnString += "Fizz";
            }
            if (number % 5 == 0)
            {
                returnString += "Buzz";
            }
            return returnString;
        }
    }
}