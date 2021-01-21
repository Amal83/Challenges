using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Challenges200
{
    class Program
    {
        private static int[] primes = new int[] { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97 };
        static void Main(string[] args)
        {
            //---------Challenge 201----------------------------------------------
            Console.WriteLine("\n**************Challenge 201****************");
            Console.WriteLine("The function takes a string, transforms all \nbut the last four characters into `#´ and returns the new masked string.\n");
            Console.WriteLine(Maskify("4556364607935616"));
            Console.WriteLine(Maskify("64607935616"));
            Console.WriteLine(Maskify("1"));
            Console.WriteLine(Maskify(""));
            
              //---------Challenge 202----------------------------------------------
            Console.WriteLine("\n**************Challenge 202****************");
            Console.WriteLine("The function takes a positive integer and \nreturns a string expressing how the number can be made by multiplying powers of its prime factors..\n");

            ExpressFactors(2);
            ExpressFactors(4);
            ExpressFactors(10);
            ExpressFactors(60);
            
            //---------Challenge 203----------------------------------------------
            Console.WriteLine("\n**************Challenge 203****************");
            Console.WriteLine("The function that finds a target number in a list of prime numbers. \nImplement a binary search algorithm in your function. \nThe target number will be from 2 through 97. If the target is prime then return 'yes' else return 'no'.\n");

            Console.WriteLine(IsPrime(primes, 3));
            Console.WriteLine(IsPrime(primes, 4));
            Console.WriteLine(IsPrime(primes, 67));
            Console.WriteLine(IsPrime(primes, 36));
            
            //---------Challenge 204----------------------------------------------
            Console.WriteLine("\n**************Challenge 204****************");
            Console.WriteLine("The function to return the amount of potatoes there are in a string.\n");

            Console.WriteLine(Potatoes("potato"));
            Console.WriteLine(Potatoes("potatopotato"));
            Console.WriteLine(Potatoes("potatoapple"));
            
            //---------Challenge 205----------------------------------------------
            Console.WriteLine("\n**************Challenge 205****************");
            Console.WriteLine("\nEncrypting.");
            foreach (int num in Encrypt("Hello"))
            {
                Console.Write(num + ", ");
            }

            Console.WriteLine("\nDecrypting.");
            Console.WriteLine(Decrypt(new int[] { 72, 33, -73, 84, -12, -3, 13, -13, -68 }));

            Console.WriteLine("\nEncrypting.");
            foreach (int num in Encrypt("Sunshine"))
            {
                Console.Write(num + ", ");
            }
            Console.WriteLine("\n**************The END****************");
        }
        
        /// <summary>
        /// Challenge 201
        /// The function takes a string, transforms all but the last four characters into `#´ and returns the new masked string.
        /// Examples Challenge 201:
        /// Maskify("4556364607935616") ➞ "############5616"
        /// Maskify("64607935616") ➞ "#######5616"
        /// Maskify("1") ➞ "1"
        /// Maskify("") ➞ ""
        /// </summary>
        /// <param name="input">A sting that shuld be masked, except the last four characters.</param>
        /// <returns>Masked string.</returns>
        public static String Maskify(string input)
        {
            return input.Length > 4 ? input.Substring(input.Length - 4).PadLeft(input.Length, '#') : input;

            // example for discussion
            //if (input.Length > 4)
            //{
            //    return input.Substring(input.Length - 4).PadLeft(input.Length, '#');
            //}
            //return input;
        }
        
        /// <summary>
        /// Challenge 202.
        /// The method takes a positive integer and returns a string expressing how the number can be made by multiplying powers of its prime factors.
        /// Examples:
        /// ExpressFactors(2) ➞ "2"
        /// ExpressFactors(4) ➞ "2^2"
        /// ExpressFactors(10) ➞ "2 x 5"
        /// ExpressFactors(60) ➞ "2^2 x 3 x 5"
        /// </summary>
        /// <param name="input">An integer number</param>
        public static void ExpressFactors(int input)
        {
            var result = new List<int>();

            // find out how many time can be divided by two.
            while (input % 2 == 0)
            {
                result.Add(2);
                input /= 2;
            }

            // find out other primes.
            int factor = 3;
            while (factor * factor <= input)
            {
                if (input % factor == 0)
                {
                    result.Add((int)factor);
                    input /= factor;
                }
                else
                {
                    factor += 2;
                }
            }
            // If num is not 1, then whatever is left is prime.
            if (input > 1) result.Add(input);

            var keeper = 0;
            for (int x = 0; x < result.Count(); x++)
            {

                if (result.ElementAt(x) == keeper)
                {
                    Console.Write("^" + result.ElementAt(x));
                    keeper = result.ElementAt(x);
                }
                else if (x == 0 || (x == result.Count() - 1 && result.Count() != 2))
                {
                    Console.Write(result.ElementAt(x));
                    keeper = result.ElementAt(x);
                }
                else if (result.Count() == 2 && result.ElementAt(x) != keeper)
                {
                    Console.Write("x" + result.ElementAt(x));
                    keeper = result.ElementAt(x);
                }
                else
                {
                    Console.Write("x" + result.ElementAt(x) + "x");
                    keeper = result.ElementAt(x);
                }

            }
            Console.WriteLine();
        }
        
        /// <summary>
        /// Challenge 203
        /// The method finds a target number in a list of prime numbers. Implement a binary search algorithm in your function. The target number will be from 2 through 97. If the target is prime then return "yes" else return "no".
        /// Examples:
        /// IsPrime(primes, 3) ➞ "yes"
        /// IsPrime(primes, 4) ➞ "no"
        /// IsPrime(primes, 67) ➞ "yes"
        /// IsPrime(primes, 36) ➞ "no"
        /// </summary>
        /// <param name="premes">fex: int[] primes = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97 }</param>
        /// <param name="input"> A integer number that shuld be checked.</param>
        /// <returns>True or false</returns>
        public static String IsPrime(int[] premes, int input)
        {
            // check if it is true
            bool flag = premes.Contains(input);
            if (flag) return "yes";
            return "no";
        }
        
        /// <summary>
        /// Challenge 204.
        /// Count the amount of potatoes there are in a string.
        /// Examples: 
        /// Potatoes("potato") ➞ 1
        /// Potatoes("potatopotato") ➞ 2
        /// Potatoes("potatoapple") ➞ 1
        /// </summary>
        /// <param name="text">input a text</param>
        /// <returns>amunt of potatoes</returns>
        public static int Potatoes(string text)
        {
            return Regex.Matches(text, "potato").Count;
        }
        
        
        /// <summary>
        /// Challenge 205
        /// Examples
        /// Encrypt("Hello") ➞ [72, 29, 7, 0, 3]
        /// Encrypt("Sunshine") ➞ [83, 34, -7, 5, -11, 1, 5, -9]
        /// </summary>
        /// <returns></returns>
        public static List<int> Encrypt(string text)
        {
            // list for return
            var result = new List<int> { };
            // keep previews char code to  subtrac from next char code
            var decreaser = 0;
            foreach (char c in text)
            {
                result.Add((int)c - decreaser);
                decreaser = (int)c;

            }
            return result;
        }
        /// <summary>
        /// Challenge 205
        /// Examples
        /// Decrypt([ 72, 33, -73, 84, -12, -3, 13, -13, -68 ]) ➞ "Hi there!"
        /// </summary>
        /// <returns></returns>
        public static String Decrypt(int[] input)
        {
            var result = "";
            //  sum of previous number to add to the upcoming number as next char code 
            var increaser = 0;

            foreach (int n in input)
            {
                result = result + (char)(n + increaser);
                increaser += n;
            }
            return result;
        }
        
        

    }
}
