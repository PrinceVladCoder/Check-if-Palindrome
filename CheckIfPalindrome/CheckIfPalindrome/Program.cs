using System;

namespace CheckIfPalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lets check if a word is a Palindrome");
            Console.WriteLine(" ");
            Console.WriteLine("Please enter a word: ");
            string userWord = Console.ReadLine();
            Console.WriteLine(userWord);

            char[] inputArray = userWord.ToCharArray();
            Array.Reverse(inputArray);
            string reverSed = new string(inputArray);

            
            if(userWord == reverSed)
            {
                Console.WriteLine("This word is a palindrome!");
                Console.WriteLine(reverSed);
            }
            else if(userWord != reverSed)
            {
                Console.WriteLine("This word is not a palindrome");
                Console.WriteLine(reverSed);
            }
        }
    }
}
