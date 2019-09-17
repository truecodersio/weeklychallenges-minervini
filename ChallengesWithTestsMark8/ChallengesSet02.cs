using System;
using System.Collections.Generic;
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
            return vals.Length % 2 == 0;
        }

        public bool IsNumberEven(int number)
        {
            return number % 2 == 0;
        }

        public bool IsNumberOdd(int num)
        {
            return num % 2 != 0;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null || numbers.Count() == 0)
                return 0;
            return numbers.Max() + numbers.Min();
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (str1.Count() < str2.Count())
                return str1.Count();
            return str2.Count();
        }

        public int Sum(int[] numbers)
        {
            if (numbers == null)
                return 0;
            return numbers.Sum();
        }

        public int SumEvens(int[] numbers)
        {
            int evenSum = 0;
            if (numbers == null || numbers.Length == 0)
                return 0;
            foreach (var number in numbers)
                if (number % 2 == 0)
                    evenSum += number;
            return evenSum;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null)
                return false;
            return numbers.Sum() % 2 != 0;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if (number <= 1)
                return 0;
            return number / 2;
        }
    }
}
