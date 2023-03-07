﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            //return numbers .Where filters through a list
            //=> lamba sign means foreach number in numbers if number % 2 is even then add wjth.Sum method
            // - numbers means to subtract all numbers that are not even. 

           return numbers.Where(x =>x % 2 == 0).Sum() - numbers.Where(x => x % 2 != 0).Sum();
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            var list = new List<int> { str1.Length, str2.Length, str3.Length,str4.Length };
            return list.Min();
            
            //Created a list of the string variables.
            //.Min method returns the minimum value in a sequence. 
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            var list = new List<int> { number1, number2,number3, number4 };
            return list.Min();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
           biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            return (sideLength1 + sideLength2 > sideLength3 && sideLength2 + sideLength3 > sideLength1 && sideLength1 + sideLength3 > sideLength2);
        }

        public bool IsStringANumber(string input)       //a string was passed into method parameter.
        {
            var isNumber = double.TryParse(input, out double number);  //TryParse parses string but also gives a bolean value. isNumber is a bool
                                                                       //number variable in parameter is holding parse value. isNumber is telling wether it can parse or not.
            return isNumber;                                           //We only return isNumber because we only want to knnow if string is a number. true or false.
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            var amount= objs.Length;
            var majority = (amount / 2) + 1;
            var count = 0;

            foreach (var obj in objs)
            {
                if (obj == null)
                {
                    count++;
                }

            }
                if(count>= majority)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }

            var n = numbers.Where(num => num % 2 == 0);

            if (n.Count() == 0)
                return 0;
            return n.Average();

        }

        public int Factorial(int number)
        {
            var fact = 1;

            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            for (int i = number; i > 0; i--)
            {
                fact *= i;
            }
            return fact;
        }
    }
}
