using System;

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

    }
}
