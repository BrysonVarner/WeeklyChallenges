using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Data;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return Char.IsLetter(c); 
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            int elements = vals.Count();
            if (elements % 2 == 0)
            {
                return true;
            } 
            else
            {
                return false;
            }

        }

        public bool IsNumberEven(int number)
        {
           return (number % 2 == 0) ? true : false;
        }

        public bool IsNumberOdd(int num)
        {
            return (num % 2 != 0) ? true : false;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null)
            {  return 0; }
            if (numbers.Count() == 0)
            { return 0; }
            return numbers.Min() + numbers.Max();    

        }

        public int GetLengthOfShortestString(string str1, string str2)
        {

            int count1 = str1.Length;
            int count2 = str2.Length;
            if (count1 < count2)
            {
                return count1;
            }
            else 
            {
                return count2;
            }
        }

        public int Sum(int[] numbers)
        {
            if (numbers == null)
            { return 0; }
            int sum = numbers.Sum();
            return sum;
            
        }

        public int SumEvens(int[] numbers)
        {
            if (numbers == null)
            { return 0 ; }

            int result = 0;

            foreach (int i in numbers)
            {
                if (i % 2 == 0)
                {
                    result += i;
                }
            }
            return result;
        }

        public bool IsSumOdd(List<int> numbers)
        {   
            if (numbers == null)
            { return false; }
            bool oddCheck = (numbers.Sum() % 2 != 0)? true : false;
            return oddCheck;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if (number == null) { return 0; }
            if (number < 0) { return 0; }

            if (number % 2 == 0)
            {
                return number / 2;
            }
            else  
            {
                return ((number - 1) / 2);
            }
            

        }
    }
}
