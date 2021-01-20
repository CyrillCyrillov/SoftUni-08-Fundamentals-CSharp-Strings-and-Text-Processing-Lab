using System;
using System.Linq;
using System.Text;

namespace Task04_Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] banedWords = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            string text = Console.ReadLine();

            foreach (var ban in banedWords)
            {
                string newWord = string.Empty;
                for (int i = 1; i <= ban.Length; i++)
                {
                    newWord += "*";
                }

                text = text.Replace(ban, newWord);
            }
            
            Console.WriteLine(text);
        }
    }
}
