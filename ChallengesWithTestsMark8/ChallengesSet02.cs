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


            throw new NotImplementedException();

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
            throw new NotImplementedException();
        }

        public int SumEvens(int[] numbers)
        {
            throw new NotImplementedException();
        }

        public bool IsSumOdd(List<int> numbers)
        {
            throw new NotImplementedException();
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            throw new NotImplementedException();
        }
    }
}
