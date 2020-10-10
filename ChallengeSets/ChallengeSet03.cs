using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengeSets
{
    public class ChallengeSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            if (vals == null)
            {
                return true;
            }
            else
            {
                foreach (var elements in vals)
                {
                    if (elements == false)
                    {
                        return true;
                    }
                }

                return false;
            }
            
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }
            else
            {
                return numbers.Sum() % 2 != 0;
            }
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            if (password.Any(char.IsUpper) && password.Any(char.IsLower) && password.Any(char.IsNumber))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public char GetFirstLetterOfString(string val)
        {
            char first = val[0];
            return first;
        }

        public char GetLastLetterOfString(string val)
        {

            char last = val[^1];
            return last;
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
            {
                return 0;
            }
            else
            {
                var expected = (dividend / divisor);
                return expected;
            }
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] - nums[0];
        }
        public int[] GetOddsBelow100()
        {
            List<int> numbers = new List<int>();
            for(int a = 0; a <= 100; a++)
            {
                if(a % 2 != 0)
                {
                    numbers.Add(a);
                }
            }
            int[] numbers1 = new int[numbers.Count];
            for (int b = 0; b < numbers.Count; b++)
            {
                numbers1[b] = numbers[b];
            }
            return numbers1;
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
           
        }
    }
}
