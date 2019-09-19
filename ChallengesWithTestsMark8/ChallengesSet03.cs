using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            foreach (var val in vals)
            {
                if (val == false)
                    return true;
            }
            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            int oddSum = 0;
            if (numbers == null)
            {
                return false;
            }
            foreach (var number in numbers)
            {
                if (number % 2 != 0)
                {
                   oddSum += number;
                }
            }
            return oddSum % 2 != 0;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            if (password.Any(char.IsUpper) && password.Any(char.IsLower) && password.Any(char.IsNumber))
            {
                return true;
            }
            return false;
        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            return val[val.Length - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0 || dividend == 0)
            {
                return 0;
            }
            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length -1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            int i = 0;
            int[] array = new int[50];
            for (int Odds = 1; Odds < 100; Odds += 2)
            {
                array[i] = Odds;
                i++;
            }
            return array;
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
