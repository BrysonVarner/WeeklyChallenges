using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            List<int> evenList = new List<int>();
            List<int> oddList = new List<int>();
            foreach (int number in numbers)
            {
                if (number == 1)
                {
                    oddList.Add(number);
                }
                else if (number % 2 != 0)
                {
                    oddList.Add(number);
                }
                else if (number % 2 == 0)
                {
                    evenList.Add(number);
                }
                else
                {
                    oddList.Add(number);
                }
            }
            int total = evenList.Sum() - oddList.Sum();
            return total;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            List<string> list = new List<string> { str1, str2, str3, str4};
            return list.Min(i => i.Length); 

        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            List<int> ints = new List<int> { number1, number2, number3, number4 };
            return ints.Min(i => i);
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
            
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if (sideLength1 + sideLength2 > sideLength3 && sideLength2 + sideLength3 > sideLength1 && sideLength1 + sideLength3 > sideLength2)
            { return true; }
            else 
            { return false; }
        }

        public bool IsStringANumber(string input)
        {
            return ((input == null || input == "") ? false : double.TryParse(input, out double result));
           
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            var isNull = 0;            
            foreach (var obj in objs) 
            { 
                if (obj == null)
                {
                    isNull++;
                }
            }
            if (isNull > objs.Count()- isNull)
            { return true; }
            else { return false; }

        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null)
            { return 0; }

            if (numbers.Length == 0)
            { return 0; }

            var n = numbers.Where(num => num % 2 == 0);

            if (n.Count() == 0)
            { return 0; }

            return n.Average();
        }

        public int Factorial(int number)
        {
            var factorial = 1;

            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            for (int i = number; i > 0; i--)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}
