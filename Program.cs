using System;

namespace Array.BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество элементов массива: \t");
            int ArrNumber = int.Parse(Console.ReadLine());
            int[] array = new int[ArrNumber];

            for (int l = 0; l < ArrNumber; l++)
            {
                Console.Write($"\nВведите число под номером {l + 1} \t");
                array[l] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            Console.Write("Введите число для определения индекса: \t");
            int value = int.Parse(Console.ReadLine());


            for (int z = 0; z < array.Length; z++)
            {
                for (int m = 0; m < array.Length - 1; m++)
                {
                    if (array[m] > array[m + 1])
                    {
                        int temp = array[m + 1];
                        array[m + 1] = array[m];
                        array[m] = temp;
                    }
                }
            }

            int L = 0;
            int R = ArrNumber;
            int k;

            while (L < R)
            {
                k = (R + L) / 2;
                if (array[k] == value)
                    Console.WriteLine("\nИндекс числа в массиве: " + "\t" + k);
                if (array[k] < value)
                    L = k;
                else
                    R = k;

            }

            Console.ReadLine();


        }
    }


}
