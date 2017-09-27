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

            if (option == "1")
            {
                Console.WriteLine("How many numbers do you wish to compare?");
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

                int smallestNumber = SmallestNumberAlgorithm(numbersArray);
                Console.WriteLine("The smallest number is: {0}", smallestNumber);
                numbersArray = Array.Empty<int>();
                Console.ReadKey();
            }
            else if (option == "2")
            {
                int smallNumber = SmallestNumberAlgorithm(numbersArray);
                
            }
            else if (option == "3")
            {
                Environment.Exit(0);
            }

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

        private static int GreatestCommonDivisor(int[] numbers, int largeNumber)
        {
            int gCF = 0;
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
             */

            return gCF;
        }
    }
}
