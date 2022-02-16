using System;
using System.Collections.Generic;//need this to use List
using System.Text;//needed for StringBuilder
using System.Linq;

namespace ConsoleAppCollectionsTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //NumberArray();

            //StringList();

            //StringSecret();

            //StringBuilderEx();

            //StringEx();

            //CharArray();

            //TimeTestOfStringVSStringBuilder();
        }

        private static void TimeTestOfStringVSStringBuilder()
        {
            string contender1 = "";

            DateTime startForContender1 = DateTime.Now;

            for (int i = 0; i < 10_000; i++)
            {
                contender1 = contender1 + '*';
            }

            DateTime endForContender1 = DateTime.Now;

            StringBuilder contender2 = new StringBuilder();

            DateTime startForContender2 = DateTime.Now;

            for (int i = 0; i < 10_000; i++)
            {
                contender2.Append('*');
            }

            DateTime endForContender2 = DateTime.Now;

            Console.WriteLine($"String time: {endForContender1 - startForContender1}");
            Console.WriteLine($"StringBuilder time: {endForContender2 - startForContender2}");
        }

        private static void CharArray()
        {
            string originalText = "Hello world";

            char[] textAsCharArray = originalText.ToCharArray();

            Console.Write("Before: ");
            PrintArrayContent(textAsCharArray);

            MakeTextUpperCase(textAsCharArray);

            Console.Write("After: ");
            PrintArrayContent(textAsCharArray);
            
            Console.WriteLine($"Test {textAsCharArray}");

            Array.Fill(textAsCharArray, '*');
            
            Console.WriteLine(textAsCharArray);
        }

        static void PrintArrayContent(char[] toPrint)
        {
            foreach (char symbol in toPrint)
            {
                Console.Write(symbol);
            }
            Console.WriteLine();
        }

        private static void MakeTextUpperCase(char[] textAsCharArray)
        {
            string temp = new string(textAsCharArray);
            temp = temp.ToUpperInvariant();

            for (int i = 0; i < textAsCharArray.Length; i++)
            {
                textAsCharArray[i] = temp[i];
            }
        }

        private static void StringBuilderEx()
        {
            //new String(/* can inset char or char array so the string will have that information inside of it when its created */);
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append("Hello");
            stringBuilder.Append(' ');
            stringBuilder.Append("World");

            AlterText(stringBuilder);

            Console.WriteLine(stringBuilder);
        }

        static void AlterText(StringBuilder textToAlter)
        {
            textToAlter.Insert(5, ", I love to code and this i tell to the ");
        }


        private static void StringEx()
        {
            //new String(/* can inset char or char array so the string will have that information inside of it when its created */);
            string stringEx;

            stringEx = "Hello";
            stringEx += ' ';
            stringEx += "World";

            StringAlterText(stringEx);

            Console.WriteLine("Inside StringEx: " + stringEx);
        }
        static void StringAlterText(string textToAlter)
        {
            textToAlter = textToAlter.Insert(5, ", I love to code and this i tell to the ");
            Console.WriteLine("Inside StringAlterText: " + textToAlter);
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
