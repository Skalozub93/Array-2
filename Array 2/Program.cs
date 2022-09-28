using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_2
{
    internal class Program
    {
        static void Numbers(int ROWS, int COLS)
        {
            int[,] array = new int[COLS, ROWS];

            int x = 1;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = x;
                    x++;
                }
            }

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        static void Main()
        {
            Console.WriteLine("Please, enter numbers of your array");

            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Numbers(rows, cols);
        }
    }
}
