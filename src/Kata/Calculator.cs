using System.Collections.Generic;

namespace Kata.Spec
{
    public class Calculator
    {
        public int Add(string number = "")
        {
            if (string.IsNullOrEmpty(number))
            {
                return 0;
            }

            if (number.Contains(","))
            {
                string[] numbers = number.Split(",");
                if (numbers.Length == 2)
                {
                    int number1 = int.Parse(numbers[0]);
                    int number2 = int.Parse(numbers[1]);
                    
                    return number1 + number2;
                }
            }
            
            return int.Parse(number);
        }
    }
}