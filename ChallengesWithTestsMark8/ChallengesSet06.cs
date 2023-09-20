using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Net.NetworkInformation;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if (words == null) return false;
            

            foreach (var item in words)
            {
                if (item == null && ignoreCase)
                {
                    return false;
                }                 
                else if (word == item)
                {
                    return true;
                }
                else if (ignoreCase && word.ToLower() == item.ToLower())
                {
                    return true;
                }

            }
            return false;
        }

        public bool IsPrimeNumber(int num)
        {
            if (num < 2)
            {
                return false;
            }

            int a = 0;

            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    a++;
                }
            }
            
            if (a == 2)
            {
                return true;
            }
            else 
            { 
                return false; 
            }
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            if (str == "")
            { 
                return -1; 
            }
            else if (str.Length == 1)
            {
                return 0;
            }
            
            for (int i = str.Length - 1 ; i >= 0; i--)
            {
                if (i == str.Length - 1)
                {
                    if (str[i] != str[i - 1] && str[i] != str[0])
                    {
                        return i;
                    }
                }
                else if (i == 0)
                {
                    if (str[i] != str[i + 1])
                    {
                        return i;
                    }
                }
                else if (str[i] != str[i - 1] && str[i] != str[i + 1])
                {  
                    return i;
                }
            }
            return -1;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            if (numbers == null)
            {  
                return 0; 
            }

            int[] count = new int[numbers.Length];            
            for (int i = 0; i < numbers.Length; i++)
            {
                int duplicates = 1;
                for (int j = i + 1;  j < numbers.Length; j++)
                {
                    if ((numbers[j] == numbers[i]))
                    {
                        duplicates += 1;
                    }
                    else
                    {
                        break;
                    }
                }
                count[i] = duplicates;

            }
            return count.Max();
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {            
            if (elements == null || elements.Count == 0 || n < 1)
            {
                return new double[] { };
            }
            else if (n == 1)
            {
                return elements.ToArray();
            }
            double[] newNthArr = new double[(elements.Count / n)];
            int newArrCount = 0;
            for (int i = n - 1; i < elements.Count; i += n)
            {
                newNthArr[newArrCount] = elements[i];
                newArrCount++;
            }
            return newNthArr;
        }
    }
}
