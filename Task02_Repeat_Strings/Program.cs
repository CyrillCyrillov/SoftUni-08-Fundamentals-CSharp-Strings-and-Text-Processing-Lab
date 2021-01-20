using System;
using System.Linq;

namespace Task02_Repeat_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputWords = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
            string repeatWord = string.Empty;

            foreach (var nextWord in inputWords)
            {
                for (int i = 0; i < nextWord.Length; i++)
                {
                    repeatWord += nextWord;
                }
            }
            
            
            Console.WriteLine(repeatWord);
        }
    }
}
