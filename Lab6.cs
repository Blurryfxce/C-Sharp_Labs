using System;

namespace Lab6
{
    class Program
    {
        static void Revers(string text)
        {
            string backwards = "";
            for(int i = text.Length - 1; i >= 0; i--)
            {
                backwards += text[i];
            }
            Console.WriteLine(backwards);
        }
       
        static void Main(string[] args)
        {
            Console.WriteLine("Введiть текст або число: ");
            string yourText = Console.ReadLine();
            Revers(yourText);  
        }
    }
}
