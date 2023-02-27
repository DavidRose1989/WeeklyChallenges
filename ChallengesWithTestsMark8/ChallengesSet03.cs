using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {


            foreach (var item in vals)
            {
                if (item == false)
                {
                    return true;
                }

            }
            return false;

        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }
            int sumOffOdds = 0;
            foreach (var number in numbers)
            {
                if (number % 2 != 0)
                {
                    sumOffOdds += number;
                }

            }
            if (sumOffOdds % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }


        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            var isUpper = false;
            var isLower = false;
            var isNumber = false;

            foreach (var letter in password)
            {
                if (char.IsLower(letter))
                {
                    isLower = true;
                }
                if (char.IsUpper(letter))
                {
                    isUpper = true;
                }
                if (char.IsNumber(letter))
                {
                    isNumber = true;
                }

            }
            return isUpper && isLower && isNumber;


        }

        public char GetFirstLetterOfString(string val)
        {
            char firstLetter = val[0];

            foreach (char letter in val)
            {
                if (char.IsUpper(letter))
                {
                    firstLetter = val[0];
                }

            }
            return firstLetter;
        }




        public char GetLastLetterOfString(string val)
        {
            char lastLetter = val[val.Length - 1];

            foreach (var letter in val)
            {
                if (char.IsLower(letter))
                {
                    lastLetter = val[val.Length - 1];
                }

            }
            return lastLetter;

        }

        public decimal Divide(decimal dividend, decimal divisor)
        {

            if (divisor == 0)
            {
                return 0;
            }
            else
            {
                return dividend / divisor;     
            }

            
        } 
    

    



    public int LastMinusFirst(int[] nums)
    {
            return nums.Last() - nums[0];

        }

    public int[] GetOddsBelow100()
    {

            int[] countOdd = new int[50];
            int startpoint = 0;

            for (int i = 1; i < 100; i++)

                if (i % 2 != 0)
                {
                    countOdd[startpoint] = i;
                    startpoint++;
                }
            return countOdd;
                
     //return Enumberable.Range(1, 100).Where(x => % 2 != 0).ToArray90;
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


