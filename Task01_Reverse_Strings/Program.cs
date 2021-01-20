using System;

namespace Task01_Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputWord = string.Empty;
            
            while (true)
            {
                inputWord = Console.ReadLine();

                if(inputWord.ToUpper() == "END")
                {
                    break;
                }

                string reverseWord = string.Empty;

                for (int i = inputWord.Length - 1; i >= 0; i--)
                {
                    reverseWord = reverseWord + inputWord[i];
                }

                Console.WriteLine($"{inputWord} = {reverseWord}");

            }
        }
    }
}
