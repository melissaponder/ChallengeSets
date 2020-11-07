using System;
using System.Collections.Generic;

namespace ChallengeSets
{
    public class ChallengeSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            return ((startNumber / n) + 1) * n;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            for (int i = 0; i < businesses.Length; i++)
            {
                businesses[i] = new Business()
                {
                    Name = "CLOSED",
                    TotalRevenue = 0,
                };
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0) return false;
            int Number = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < Number)
                {
                    return false;
                }
                Number = numbers[i];
            }
            return true;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            int sum = 0;
            if (numbers == null)
            {
                return 0;
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    try { sum += numbers[i + 1]; }
                    catch (System.IndexOutOfRangeException)
                    {

                    }
                }
            }
            return sum;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if (words == null || words.Length == 0 || words.Length == 1)
            {
                return "";
            }
            string sentence = "";
            int count = 0;
            foreach (string Word in words)
            {
                if (Word == " " || Word == "")
                {
                    count++;
                    continue;
                }
                string toAdd = Word.Replace(" ", "");
                sentence += toAdd;
                if (count < words.Length - 1 && toAdd != "") sentence += " ";
                else if (count == words.Length - 1) sentence += ".";

                count++;
            }
            return sentence;
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            if (elements == null) return new double[0];
            List<double> everyFourth = new List<double>();
            for (int i = 1; i <= elements.Count; i++)
            {
                if (i % 4 == 0)
                {
                    everyFourth.Add(elements[i - 1]);
                }
            }
            return everyFourth.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (i == j) continue;
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
