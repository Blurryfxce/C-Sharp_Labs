using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {

            int nn;
            int nk;
            int k;
            double res = 0;

            nn = int.Parse(Console.ReadLine());
            nk = int.Parse(Console.ReadLine());

            for (k = nn; k <= nk; k++)
            {
                res += (Math.Pow(k, 2) - 3) / (Math.Pow(k, 2) - (Math.Pow(-1, k)) * k + 3);
            }

            Console.WriteLine(res);
            Console.ReadLine();


        }
    }
}

