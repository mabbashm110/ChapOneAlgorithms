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
            Console.WriteLine("Pick an option: \n1. Small Numbers Algorithm \n2. Greatest Common Divisor \n3. Exit");
            string option = Console.ReadLine();
            RunAlgorithmSelection(option);
        }
        private static void RunAlgorithmSelection(string option)
        {
            int[] numbersArray = null;
            string arraySize = null;
            string message = "";

            if (option == "0")
            {
                RunCommand();
            }
            else if (option == "3")
            {
                Environment.Exit(0);
            }

            numbersArray = AllocateArray(numbersArray, arraySize);

            if (option == "1")
            {
                
                int smallestNumber = Algorithms.SmallestNumberAlgorithm(numbersArray);
                Console.WriteLine("The smallest number is: {0}", smallestNumber);
                numbersArray = Array.Empty<int>();
                //Console.ReadKey();
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
                    int result = Algorithms.GreatestCommonDivisor(numbersArray);
                    Console.WriteLine("GCF is: {0}\n", result);
                }

            }
            //Console.WriteLine("The smallest number is: {0}", smallestNumber);
            //numbersArray = Array.Empty<int>();
            //Console.ReadKey();

        }

        public static int[] AllocateArray(int[] numbersArray, string arraySize)
        {
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

            return numbersArray;
        }
       

    }
}
