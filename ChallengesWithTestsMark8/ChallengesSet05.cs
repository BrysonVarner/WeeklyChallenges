using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    { 
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            return ((startNumber / n) + 1) * n;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            for (int i = 0; i < businesses.Length; i++)
            {
                if (businesses[i].TotalRevenue == 0)
                {
                    businesses[i].Name = "CLOSED";
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return false;
            }

            for (var i = 1; i < numbers.Length; i++)
            {               
                if (numbers[i] < numbers[i - 1])
                {
                    return false;
                }             
                
            }

            return true;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }

            var sum = 0;
            for (var i = 0; i < numbers.Length;  i++)
            {
                if (numbers.Length - 1 == i)
                {
                    break;
                }
                else if (numbers[i]%2 == 0)
                {
                    sum += numbers[i + 1];
                }
            }

            return sum;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if (words == null || words.Length == 0)
            {
                return "";
            }

            var newString = "";
            for (var i = 0;i < words.Length;i++)
            {   
                if (words[i] == "" || words[i] == " " || words[i] == "  ")
                {
                    newString += "";
                }                
                else if (i == words.Length - 1)
                {
                    newString += words[i].Trim();                    
                    newString += ".";
                }
                else
                {
                    newString += words[i].Trim() + " ";
                }
            }
            return newString;
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            if (elements == null || elements.Count < 4)
            {
                return new double[] { };
            }
            int indexCount = elements.Count / 4;
            var result = new double[indexCount];
            int newSlotCounter = 0;
            for (var i = 3;i<elements.Count;i+=4)
            {
                result[newSlotCounter] = elements[i];
                newSlotCounter++;
            }
            return result;
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            if (nums == null || nums.Length == 0)
            {
                return false;
            }

            for (int i =0;  i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if ((nums[i] + nums[j]) == targetNumber)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
