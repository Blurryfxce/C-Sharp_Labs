using System;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            /* (вар.8) Дана матриця цілих чисел розміру m *  n. 
            Вивести номер її 1) останнього; 2) першого рядка (стовпчика), 
            що містить рівну кількість додатних і від’ємних елементів (нульові елементи не враховуються). 
            Якщо таких рядків (стовпчиків) немає, то вивести 0. */

            int[,] array = new int[,]
            {
                {1, -2, 0,34},
                {4, 5, -6,-42},
                {6, -7, 8,42},
                {7, -8, -9,69}
            };
            for(int i = 0; i < array.GetLength(0); i++)     //Виводим базовий масив
            {
                for(int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i,j] + "\t");
                }
                Console.WriteLine();
            }

            int PosCount = 0;    //Змінні для перевірки однакової кількості додатніх і від'ємних чисел
            int NegCount = 0;
            int firstRow = 0;     //Номер першого рядка який буде відповідати вимогам: "однаково від'ємних і додатніх"
            int lastRow = 0;    //Номер останнього потрібного рядка
            bool isAnyRow = false;  //Чи є хочаб 1 потрібний рядок

            for (int i = 0; i < array.GetLength(0); i++)    //Перебираємо масив по рядкам до появи потрібного рядка
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] > 0)
                    {
                        PosCount++;
                    }
                    else if (array[i, j] < 0)
                    {
                        NegCount++;
                    }
                }
                if (PosCount == NegCount)
                {
                    firstRow = i;
                    isAnyRow = true;
                    break;
                }
                else
                {
                    PosCount = 0;
                    NegCount = 0;
                }
            }

            PosCount = 0;
            NegCount = 0;

            for (int i = 0; i < array.GetLength(0); i++)    //Перебираємо масив по рядкам до останнього рядка
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] > 0)
                    {
                        PosCount++;
                    }
                    else if (array[i, j] < 0)
                    {
                        NegCount++;
                    }
                }
                if (PosCount == NegCount)
                {
                    lastRow = i;
                }
                else
                {
                    PosCount = 0;
                    NegCount = 0;
                }
            }

            if (isAnyRow == true)
            {
                Console.WriteLine($"Перший рядок де рiвна кiлькiсть додатних i вiд’ємних елементiв: {firstRow + 1}");
                Console.WriteLine($"Останнiй рядок де рiвна кiлькiсть додатних i вiд’ємних елементiв: {lastRow + 1}");
            }
            else { Console.WriteLine(0); }
        }
    }
}
