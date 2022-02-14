using System;
using System.Collections.Generic;//need this to use List

namespace ConsoleAppCollectionsTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //NumberArray();

            //StringList();

            StringSecret();
        }

        private static void StringSecret()
        {
            List<string> list = new List<string>() { "Ulf", "Kent", "Jonas" };

            int index = 0;

            while (index < list.Count)//for array use .Length
            {
                string name = list[index++];
                if (index < name.Length)
                    Console.WriteLine(name[index]);
            }

            Console.WriteLine("This list´s Capacity is: " + list.Capacity);
        }

        private static void StringList()
        {
            List<string> list = new List<string>() { "Ulf", "Kent", "Jonas" };

            int index = 0;

            while (index < list.Count)//for array use .Length
            {
                Console.WriteLine(list[index++]);
            }

            Console.WriteLine("This list´s Capacity is: " + list.Capacity);
        }

        static void NumberArray()
        {
            int amount = AskUserForInt("the amount of numbers to be inputed");

            double[] numbersArray = new double[amount];

            for (int i = 0; i < numbersArray.Length; i++)
            {
                Console.Write("Number: ");
                numbersArray[i] = Convert.ToDouble(Console.ReadLine());
            }

            //Console.WriteLine(numbersArray);//will not print the numbers inside.
            //Console.WriteLine(numbersArray.ToString());//will not print the numbers inside.(same effect as the prior line of code)
            foreach (double number in numbersArray)
            {
                Console.WriteLine(number);
            }

        }

        static int AskUserForInt(string what)
        {
            bool notANumber = true;
            int number = 0;
            do
            {
                Console.Write($"Input {what}: ");
                try
                {
                    number = int.Parse(Console.ReadLine());
                    notANumber = false;
                }
                catch (ArgumentNullException)//will probebly never happen in this method
                {
                    Console.WriteLine("No date was inputed.");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Input a hole number, Example: 1 or 2");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("The number was too big.");
                }

            } while (notANumber);

            return number;
        }
    }
}
