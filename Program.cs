using System;

namespace AnagramChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first string: ");
            string str1 = Console.ReadLine().ToLower(); // read the first string and convert it to lower case
            Console.WriteLine("Enter the second string: ");
            string str2 = Console.ReadLine().ToLower(); // read the second string and convert it to lower case

            if (IsAnagram(str1, str2))
            {
                Console.WriteLine("The two strings are anagrams.");
            }
            else
            {
                Console.WriteLine("The two strings are not anagrams.");
            }
        }

        // method to check if two strings are anagrams
        static bool IsAnagram(string str1, string str2)
        {
            // convert the strings to character arrays and sort them
            char[] arr1 = str1.ToCharArray();
            Array.Sort(arr1);
            char[] arr2 = str2.ToCharArray();
            Array.Sort(arr2);

            // compare the sorted character arrays
            return new string(arr1) == new string(arr2);
        }
    }
}
