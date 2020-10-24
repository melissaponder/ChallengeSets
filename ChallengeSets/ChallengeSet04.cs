using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengeSets
{
    public class ChallengeSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int sum = 0;
            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                {
                    sum += num;
                }
                else
                {
                    sum -= num;
                }
            }
            return sum;
            
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            int shortestString = 16;
            if (str1.Length < shortestString)
            {
                shortestString = str1.Length;
            }
            if (str2.Length < shortestString)
            {
                shortestString = str2.Length;
            }
            if (str3.Length < shortestString)
            {
                shortestString = str3.Length;
            }
            if (str4.Length < shortestString)
            {
                shortestString = str4.Length;
            }
            return shortestString;

        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            int smallestNumber = 100;
            if (number1 < smallestNumber)
            {
                smallestNumber = number1;
            }
            if (number2 < smallestNumber)
            {
                smallestNumber = number2;
            }
            if (number3 < smallestNumber)
            {
                smallestNumber = number3;
            }
            if (number4 < smallestNumber)
            {
                smallestNumber = number4;
            }
            return smallestNumber;
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if (sideLength1 + sideLength2 > sideLength3
             && sideLength1 + sideLength3 > sideLength2
             && sideLength2 + sideLength3 > sideLength1)
            {
                return true;
            }
            return false;
        }

        public bool IsStringANumber(string input)
        {
            if (double.TryParse(input, out double value))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int itemCount = objs.Length;
            int nullCount = 0;
            foreach (object obj in objs)
            {
                if (obj == null) nullCount++;
            }
            if (nullCount > itemCount / 2)
            {
                return true;
            }
            return false;
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            int average = 0;
            int evens = 0;
            foreach (var elements in numbers)
            {
                if (elements % 2 == 0)
                {
                    average += elements;
                    evens++;
                }
            }
            if (evens == 0)
            {
                return 0;
            }
            return (double)average / evens;
        }

        public int Factorial(int number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (number > 1)
            {
                return number * Factorial(number - 1);
            }
            if (number == 0)
            {
                return 1;
            }
            else
            {
                return number;
            }
        }
    }
}
