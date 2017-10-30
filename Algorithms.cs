using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChapOneAlgorithms
{
    public static class Algorithms
    {
        /// <summary>
        /// Find the smallest number in an array
        /// </summary>
        /// <param name="numbers">Parsed array of numbers input by the user</param>
        /// <returns>An integer with the smallest number</returns>
        public static int SmallestNumberAlgorithm(int[] numbers)
        {
            int smallestNumber = 0;
            int a = numbers[0];
            int b = numbers[1];

            if (a < b)
            {
                smallestNumber = a;
            }
            else
            {
                smallestNumber = b;
            }
            if (numbers.Length > 2)
            {
                for (int i = 2; i < numbers.Length; i++)
                {
                    int c = (numbers[i]);
                    if (smallestNumber < c)
                    {
                        return smallestNumber;
                    }
                    else if (smallestNumber > c)
                    {
                        smallestNumber = c;
                    }
                }
            }
            return smallestNumber;

            //    if (a < b)
            //    {
            //        smallestNumber = a;

            //        if (smallestNumber < c)
            //        {
            //            return smallestNumber;
            //        }
            //    }
            //    if ((b < a) || (b < c))
            //    {
            //        smallestNumber = b;
            //        if (smallestNumber)
            //        {

            //        }
            //    }

            //    if ((c < a) || (c < b))
            //    {
            //        smallestNumber = c;
            //    }
            //}



            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    int changeIndex = numbers[numbers.Length - (i + 1)];
            //    //int changeIndex = numbers[i];
            //    int arrayValue = numbers[i];
            //    smallestNumber = arrayValue;

            //    if (arrayValue > changeIndex)
            //    {
            //        smallestNumber = changeIndex;
            //    }
            //    else if (arrayValue < changeIndex)
            //    {
            //        smallestNumber = arrayValue;
            //    }

            //    if (/*smallestNumber != 0 &&*/ smallestNumber < arrayValue || smallestNumber < changeIndex)
            //    {
            //        return smallestNumber;
            //    }
            //    else
            //    {
            //        smallestNumber = arrayValue;
            //    }

            //}

        }

        /// <summary>
        /// Finds a Greatest common divisor using Euclidean's Algorithm
        /// </summary>
        /// <param name="numbers">Parsed array of numbers input by the user</param>
        /// <returns>An integer with GCF</returns>
        public static int GreatestCommonDivisor(int[] numbers)
        {
            //Using Euclidean Algorithm

            /* 
            * WORKING METHOD
            * Compute large number
            * Find initial modulus - large % small = result
            * Find initial quotient - (large - result)/small
            * [Loop] through the chain
            * Update large and small in every loop
            * Large number to small number and small number to result
            * Compute quotient
            * 
            * WORKED OUT EXAMPLE
            * 1071 % 462 = 147
            * a % b = r0
            * 1071 - 147 / 462 = 2
            * (a - r) / b = q0
            * 
            * [LOOP CHAIN]
            * update a and b
            * 462 % 147 = 21
            * a % b = r
            * 462 - 21 / 147 = 3
            * (a - r) / b = q
            * 
            * again update a and b
            * 147 % 21 = 0
            * a % b = r
            * 147 - 0 / 21 = 7
            * (a - r) / b = q
            * 
            * //L = (S x q) + r
                   /*
                    * q = Large number divide by small number to get q
                    * r = Modulus of L%S to get r
                    * 
                    * Steps to Algorithm:
                    * 1. First find smallest number using the smallest number algorithm
                    * 2. Find q and r
                    * 3. Compute Euclidian Algorithm to find GCD
                    * 
                    * METHOD 2 - WIKIPEDIA
                    * Find smaller number 
                    * Find modulus of large % small number
                    * if modulus <> 0 then follow again
                    * b % remainder
                    * repeat until modulus == 0
                    * when modulus == 0 
                    * gcf == remainder from previous compute
                    * /
            */

            int a = numbers[0];
            int b = numbers[1];

            int largeNumber = 0;
            int smallNumber = 0;

            //Find the larger number
            if (a > b)
            {
                largeNumber = a;
                smallNumber = b;
            }
            else
            {
                largeNumber = b;
                smallNumber = a;
            }

            //Do the math
            var result = largeNumber % smallNumber;
            var quotient = (largeNumber - result) / smallNumber;
            do
            {
                largeNumber = smallNumber;
                smallNumber = result;
                if (largeNumber != 0 || smallNumber != 0)
                {
                    result = largeNumber % smallNumber;
                    quotient = (largeNumber - result) / smallNumber;
                }
                else
                {
                    break;
                }
                //var result = smallNumber % result;
                //quotient = (smallNumber - result) / resultZero;
                //smallNumber = result;
            }
            while (result != 0);

            if (result == 0)
            {
                return quotient;
            }

            return quotient;
        }

        public static string FindSqrtSimple(double number)
        {
            string reply = Math.Sqrt(number).ToString();
            return reply;
        }

        public static string FindElementInArray(int[] numbers, int numberToSearch)
        {
            /*
             * Issue with algorithm
             * Upon debug loops through the statement
             * But upon run does not 
             */
            string message = "";
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == numberToSearch)
                {
                    return message = ("Element exists in the array, at position " + i.ToString());
                    
                }
                else if (numbers[i] != numberToSearch)
                {
                    return message = "Element does not exist in the array";
                }
            }
            return message;
        }

        public static int[] BubbleSortAlg(int[] numbers)
        {
            bool swapped;
            //int[] organisedNumbers = new int[numbers.Length];
            do
            {
                swapped = false;
                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    if (numbers[i] > numbers[i + 1])
                    {
                        int temp = numbers[i + 1];
                        //Console.WriteLine(temp);
                        numbers[i + 1] = numbers[i];
                        //Console.WriteLine(numbers[i + 1]);
                        numbers[i] = temp;
                        //Console.WriteLine(numbers[i]);
                        //Console.WriteLine(i);
                        swapped = true;

                    }

                } 
                //else
                //{
                //    int temp = numbers[i];
                //    numbers[i] = numbers[i + 1];
                //    numbers[i] = temp;
                //}
            } while (swapped == true);
            return numbers;
        }
    }
}

