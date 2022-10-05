using System;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b, c;
            bool isOpposite = false;
            Console.WriteLine("Введiть 3 цiлi числа: ");
            a = float.Parse(Console.ReadLine());
            b = float.Parse(Console.ReadLine());
            c = float.Parse(Console.ReadLine());

            if (a % 1 != 0 || b % 1 != 0 || c % 1 != 0)
            {
                Console.WriteLine("Помилка! Числа не цілі");
            }
            else if (a + b == 0 || a + c == 0 || b + c == 0)
            {
                isOpposite = true;
                Console.WriteLine(isOpposite + " (Взаємно протилежнi числа iснують)");
            }
            
            else
            {
                Console.WriteLine(isOpposite + " (Взаємно протилежних чисел не iснує)");
            }
        }
    }
}

