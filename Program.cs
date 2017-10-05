using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChapOneAlgorithms
{
    public class Program
    {
        public static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                RunCommand();
            }
        }

        private static void RunCommand()
        {
            Console.WriteLine("Pick an option: \n1. Small Numbers Algorithm \n2.Greatest Common Divisor \n3.Exit");
            string option = Console.ReadLine();
            RunAlgorithmSelection(option);
        }
        private static void RunAlgorithmSelection(string option)
        {
            int[] numbersArray = null;
            string arraySize = null;
            string message = "";

            Console.WriteLine("How many numbers would you like to evaluate?");
            do
            {
                arraySize = Console.ReadLine();
                if (arraySize == "")
                {
                    Console.WriteLine("Kindly specify a valid numerical input");
                }

            } while (arraySize == "");

            numbersArray = new int[int.Parse(arraySize)];

            for (int i = 0; i < numbersArray.Length; i++)
            {
                Console.WriteLine("Enter one number at a time and press enter");
                numbersArray.SetValue(int.Parse(Console.ReadLine()), i);
            }

            if (option == "1")
            {
                int smallestNumber = SmallestNumberAlgorithm(numbersArray);
                Console.WriteLine("The smallest number is: {0}", smallestNumber);
                numbersArray = Array.Empty<int>();
                Console.ReadKey();
            }
            else if (option == "2")
            {
                if (numbersArray.Length >= 3)
                {
                    Console.WriteLine("You cannot evaluate a GCD for more than 2 numbers.\nGo back to the main menu and try again.\n 0.Go Back");
                    option = Console.ReadLine();
                    RunAlgorithmSelection(option);
                }
                else
                {
                    int result = GreatestCommonDivisor(numbersArray);
                    Console.WriteLine("GCF is: {0}", result);
                }

            }
            else if (option == "3")
            {
                Environment.Exit(0);
            }

            else if (option == "0")
            {
                RunCommand();
            }

            //Console.WriteLine("The smallest number is: {0}", smallestNumber);
            //numbersArray = Array.Empty<int>();
            //Console.ReadKey();

        }

        private static int SmallestNumberAlgorithm(int[] numbers)
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

        private static int GreatestCommonDivisor(int[] numbers)
        {
            //Using Euclidian Algorithm
            //L = (S x q) + r
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
            //var quotient = (largeNumber - result) / smallNumber;
            do
            {
                result = smallNumber % result;
                //smallNumber = result;
            }
            while (result != 0);

            if (result == 0)
            {
                return smallNumber;
            }

            return smallNumber;
        }

        private static void getGCDResult(int[] numbers, int smallNumber)
        {

        }
    }
}
