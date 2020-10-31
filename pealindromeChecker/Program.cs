using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pealindromeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** This program checks if a word is palindrome or not ***");

            string input = "";

            while (input != "q")
            {
                Console.Write("Please enter a word: ");
                input = Console.ReadLine();
                string output = Reverse(input);
                //Console.WriteLine(output);

                if (output == input)
                {
                    Console.WriteLine(input + " is a palindrome word" + "\n");
                }
                else
                {
                    Console.WriteLine(input + " is not a palindrome word" + "\n");
                }

                Console.WriteLine("To exit the program, please enter \"q\"");
            }

            //Console.ReadLine();
        }

        static string Reverse(string input)
        {
            string result = "";
            for (int i = (input.Length - 1); i >= 0; i--)
            {
                result = result + input[i];
            }

            return result;
        }
    }
}
