using System;
using System.Collections.Generic;
using System.Globalization;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            if (startNumber == 0)
            {
                return n;
            }
            List<int> firstlist = new List<int>();
            int maxLoop = startNumber * n;
            int[] numbersDivisiblebyN = new int[0];

            for (int i = 0; i < maxLoop; i++)
            {
                if (i > startNumber && i % n == 0)
                {
                    firstlist.Add(i);
                }

            }

            firstlist.ToArray();
            return firstlist[0];
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

            for (int i = 1; i < numbers.Length; i++)
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
            int sum = 0;

            for (int i = 1; i < numbers.Length; i++)
            { 
                if (numbers[i - 1] % 2 == 0)
                {
                    sum += numbers[i];
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

            
            int goodwords = 0;
            List<string> wordslist = new List<string>();

            for (int i = 0; i < words.Length; i++)
            {

                if (words[i].Trim().Length > 0)
                {
                    wordslist.Add(words[i].Trim() + " ");

                    goodwords++;
                }
                
            }
            if (goodwords == 0)
            {
                return "";
            }
            else
            {
                return String.Join("", wordslist).Trim() + ".";
            }

        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            if (elements == null || elements.Count == 0)
            {
                return new double[0];
            }

            List<double> everyFourth = new List<double>();

            for (int i = 3; i < elements.Count; i += 4)
            {
                everyFourth.Add(elements[i]);
            }

            return everyFourth.ToArray();
            
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == targetNumber)
                    { 
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
