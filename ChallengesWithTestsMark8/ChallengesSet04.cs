using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int total = 0;
            foreach (var number in numbers)
            {
                if (number % 2 == 0)
                {
                    total += number;
                }
                else
                {
                    total -= number;
                }
            }
            return total;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            int shortestLength = str1.Length;
            var listOfStrings = new List<string> { str1, str2, str3, str4 };
            foreach (var str in listOfStrings)
            {
                if (str.Length < shortestLength)
                {
                    shortestLength = str.Length;
                }
            }
            return shortestLength; 
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            var listOfInts = new List<int> { number1, number2, number3, number4 };
            listOfInts.Sort();
            return listOfInts.ElementAt(0);
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            throw new NotImplementedException();
        }

        public bool IsStringANumber(string input)
        {
            throw new NotImplementedException();
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            throw new NotImplementedException();
        }

        public double AverageEvens(int[] numbers)
        {
            throw new NotImplementedException();
        }

        public int Factorial(int number)
        {
            throw new NotImplementedException();
        }
    }
}
