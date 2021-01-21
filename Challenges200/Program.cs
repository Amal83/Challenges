using System;
using System.Collections.Generic;
using System.Linq;

namespace Challenges200
{
    class Program
    {
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

    }
}
