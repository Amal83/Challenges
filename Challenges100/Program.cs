using System;
using System.Linq;
namespace Challenges100
{
    class Program
    {
        static void Main(string[] args)
        {
            //---------Challenge 101----------------------------------------------
            Console.WriteLine("\n**************Challenge 101****************");
            Console.WriteLine("The function takes an array of numbers \nand return both the minimum and maximum numbers, in that order.\n");

            // A void method that has console.writeLine 
            //FindMinMax(firstArray);
            //FindMinMax(secondArray);
            //FindMinMax(thirdArray);

            // the method with return 
            Console.WriteLine(String.Join(", ", FindMinMaxV2(new int[] { 1, 2, 3, 4, 5 })));
            Console.WriteLine(String.Join(", ", FindMinMaxV2(new int[] { 2334454, 5 })));
            Console.WriteLine(String.Join(", ", FindMinMaxV2(new int[] { 1, 1 })));
            
            
            //---------Chalenge 102----------------------------------------------
            Console.WriteLine("\n**************Challenge 102****************");
            Console.WriteLine("The function accepts a string of a person's first \nand last name and returns a string with the first and last name swapped.\n");
            Console.WriteLine(NameShuffle("Donald Trump"));
            Console.WriteLine(NameShuffle("Rosie O'Donnell"));
            Console.WriteLine(NameShuffle("Seymour Butts"));
            //what if enter only a name.
            Console.WriteLine(NameShuffle("Joe"));


        }
        
        
        /// <summary>
        /// Challenge 101
        /// The method is passing an array of integers and prining in console output.
        /// Example:
        /// FindMinMax([1, 2, 3, 4, 5]) ➞ [1, 5]
        /// FindMinMax([2334454, 5]) ➞ [5, 2334454]
        /// FindMinMax([1]) ➞ [1, 1]
        /// </summary>
        /// <param name="array"></param>
        public static void FindMinMax(int[] array)
        {
            var result = new int[] { };

            result = result.Concat(new int[] { array.Min() }).ToArray();
            result = result.Concat(new int[] { array.Max() }).ToArray();
            Console.WriteLine(String.Join(", ", result));

        }
        /// <summary>
        /// Challenge 101 (version2)
        /// The method is passing an array of integers to find the minimum and the maximum.
        /// Example:
        /// FindMinMax([1, 2, 3, 4, 5]) ➞ [1, 5]
        /// FindMinMax([2334454, 5]) ➞ [5, 2334454]
        /// FindMinMax([1]) ➞ [1, 1] 
        /// </summary>
        /// <param name="array">Array of integer</param>
        /// <returns>minimun and maximum of input array</returns>
        public static int[] FindMinMaxV2(int[] array)
        {
            var result = new int[] { };
            result = result.Concat(new int[] { array.Min() }).ToArray();
            result = result.Concat(new int[] { array.Max() }).ToArray();
            return result;
        }
        
        /// <summary>
        /// Challenge 102
        /// Enter full name and first name will be swapped with last name
        /// Example:
        /// NameShuffle("Donald Trump") ➞ "Trump Donald"
        /// NameShuffle("Rosie O'Donnell") ➞ "O'Donnell Rosie"
        /// NameShuffle("Seymour Butts") ➞ "Butts Seymour
        /// </summary>
        /// <param name="fullName">A full name that should be swapped</param>
        /// <returns>The swapped last name and the swapped first name.</returns>
        public static String NameShuffle(string fullName)
        {
            var splitedName = fullName.Split(' ');
            if (splitedName.Length.Equals(1))
            {
                return "Please enter a full name!";
            }
            var shuffledName = splitedName[1] + " " + splitedName[0];
            return shuffledName;
        }
        
    }
}