/*  TwoDimExamples
 *  
 *  To demonstrate the use of 2d arrays
 *  
 *  Revision History:
 *      Tony Theo..., 2023.03.15:  Created
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoDimExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Example1();
            //Example2();

            Console.ReadKey();
        }

        static void Example1()
        {
            int[,] numbers = new int[2,3];

            //add numbers from input
            for (int row = 0; row < numbers.GetLength(0); row++)
            {
                for (int col = 0; col < numbers.GetLength(1); col++)
                {
                    Console.Write($"Please enter a value for [{row}][{col}]: ");
                    numbers[row, col] = Convert.ToInt32(Console.ReadLine());
                }
            }

            //display all values
            for (int row = 0; row < numbers.GetLength(0); row++)
            {
                for (int col = 0; col < numbers.GetLength(1); col++)
                {
                    Console.Write(numbers[row, col] + " ");
                }
                Console.WriteLine();
            }


            //display values col 2
            Console.WriteLine("\nColumn 2:");

            for (int row = 0; row < numbers.GetLength(0); row++)
            {
                Console.WriteLine(numbers[row, 2]);
            }

            //display values in row index 1
            Console.WriteLine("\nRow 1:");

            for (int col = 0; col < numbers.GetLength(1); col++)
            {
                Console.Write(numbers[1, col] + " ");
            }

        }
        
        static void Example2()
        {
            int totalSales;

            int[,] sales =
            {
                { 1000, 1500, 1200, 2100 },
                { 800, 2200, 2500, 500 },
                { 1200, 1000, 700, 700 }
            };

            for (int row = 0; row < sales.GetLength(0); row++)
            {
                totalSales = 0;

                for (int col = 0; col < sales.GetLength(1); col++)
                {
                    Console.Write($"{sales[row,col]} ");
                    totalSales =  totalSales + sales[row, col];
                }

                Console.WriteLine($"   Total: {totalSales}");
            }
        }
    }
}
