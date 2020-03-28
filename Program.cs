using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAppForSmartWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = getRandomArray();
            int sumOfEvenNumbers = sumAllEvenNumbers(array);
            int sumOfOddNumbers = sumAllOddNumbers(array);
            Console.WriteLine("Сумма всех чётных чисел равна " + sumOfEvenNumbers);
            Console.WriteLine("Сумма всех нечётных чисел равна " + sumOfOddNumbers);
        }

        static int sumAllEvenNumbers(int[,] array)
        {
            int sum = 0;
            foreach (var i in array)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }
        static int sumAllOddNumbers(int[,] array)
        {
            int sum = 0;
            foreach (var i in array)
            {
                if (i % 2 != 0)
                {
                    sum += i;
                }
            }
            return sum;
        }

        static int[,] getRandomArray()
        {
            Random random = new Random();
            int x = random.Next(1, 10);
            int y = random.Next(1, 10);
            int[,] array = new int[x, y];
            for (int i = 0; i < x; i++)
                for (int j = 0; j < y; j++)
                {
                    array[i, j] = random.Next(0, 1000);
                    Console.WriteLine(array[i, j]);
                }
            return array;
        }
    }
}
