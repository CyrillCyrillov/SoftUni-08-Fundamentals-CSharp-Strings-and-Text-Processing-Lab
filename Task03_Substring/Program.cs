using System;

namespace Task03_Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string textToRemoved = Console.ReadLine();
            string text = Console.ReadLine();

            while(text.IndexOf(textToRemoved) >=0)
            {
                int index = text.IndexOf(textToRemoved);

                text = text.Remove(index, textToRemoved.Length);
            }
            
            Console.WriteLine(text);
        }
    }
}
