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
            
            //---------Challenge 103
            Console.WriteLine("\n**************Challenge 103****************");
            Console.WriteLine("The function returns true if an input string contains only uppercase or only lowercase letters.\n");
            Console.WriteLine(SameCase("hello"));
            Console.WriteLine(SameCase("HELLO"));
            Console.WriteLine(SameCase("Hello"));
            Console.WriteLine(SameCase("ketcHUp"));
            
            //---------Challenge 104----------------------------------------------
            Console.WriteLine("\n**************Challenge 104****************");
            Console.WriteLine("The function takes a string and returns either true or false depending on whether or not it's an isogram\n");
            Console.WriteLine(IsIsogram("Algorism"));
            Console.WriteLine(IsIsogram("PasSword"));
            Console.WriteLine(IsIsogram("Consecutive"));


            
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
     
        /// <summary>
        /// Challenge 103
        /// The method is checking that the input word is same case letters or not. 
        /// Examples challenge-103:
        /// SameCase("hello") ➞ true
        /// SameCase("HELLO") ➞ true
        /// SameCase("Hello") ➞ false
        /// SameCase("ketcHUp") ➞ false
        /// </summary>
        /// <param name="input">A word to check for same case letter</param>
        /// <returns>True or false</returns>
        public static bool SameCase(string input)
        {
            int upper = 0;
            int lower = 0;
            for (var i = 0; i < input.Length; i++)
            {
                if (char.IsUpper(input[i]))
                {
                    upper++;
                }
                if (char.IsLower(input[i]))
                {
                    lower++;
                }
            }
            if ((upper == 0 && lower > 0) || (upper > 0 && lower == 0))
            {
                return true;
            }
            return false;
        }
        
        /// <summary>
        /// Challenge 104
        /// The method is passing a string word and checking if that word is isogram or not.
        /// Examples challenge-104:
        /// IsIsogram("Algorism") ➞ true
        /// IsIsogram("PasSword") ➞ false
        /// Not case sensitive:
        /// IsIsogram("Consecutive") ➞ false
        /// </summary>
        /// <param name="input">A word to for isogram</param>
        /// <returns>True or false</returns>
        public static bool IsIsogram(string input)
        {
            var convertedToLower = input.ToLower();
            //Linq
            int countOfUniqueCharInInput = convertedToLower.Distinct().Count();
            // HashSet can be used too.
            // int countOfUniqueCharInInput = (new HashSet<char>(input)).Count;
            
            if (input.Length.Equals(countOfUniqueCharInInput))
            {
                return true;
            }
            return false;
        }
   
    }
}