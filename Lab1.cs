using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {

            double r;
            Console.WriteLine("Введiть радiус кулi: ");
            r = double.Parse(Console.ReadLine());
            double pi = 3.14;
            double v = 4.0 / 3.0 * pi * (r * r * r);
            double s = 4.0 * pi * (r * r);
            Console.WriteLine("Об'єм = " + v);
            Console.WriteLine("Площа поверхнi = " + s);


        }
    }
}
