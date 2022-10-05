using System;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введiть розмiр масиву:\t");
            int N = int.Parse(Console.ReadLine());
            int[] arr = new int[N];
            for (int i = 0; i < N; i++)
            {
                Console.Write($"a[{i}]=");
                arr[i] = int.Parse(Console.ReadLine());
            }
            int max = arr[0];
            int maxValue = 0;
            for (int i = 0; i < N; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                    maxValue++;
                }
            }
            int min = arr[0];
            int minValue = 0;
            for (int i = 0; i < N; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                    minValue++;
                }
            }
            Console.WriteLine("Обробка масиву...");
            if(minValue < maxValue)
            {
                for (int i = 0; i <= minValue; i++)
                {
                    Console.WriteLine(arr[i]);
                }
                for (int i = maxValue - 1; i > minValue; i--)
                {
                    Console.WriteLine(arr[i]);
                }
                for(int i = maxValue ; i < N; i++)
                {
                    Console.WriteLine(arr[i]);
                }
            }
            
            else
            {
                for (int i = 0; i <= maxValue; i++)
                {
                    Console.WriteLine(arr[i]);
                }
                for (int i = minValue - 1; i > maxValue; i--)
                {
                    Console.WriteLine(arr[i]);
                }
                for (int i = minValue; i < N; i++)
                {
                    Console.WriteLine(arr[i]);
                }
            }
            

        }
    }
}

