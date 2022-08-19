﻿internal class Program
{
    private static void Main(string[] args)
    {
        void Zadacha54()
        {
            //Задайте двумерный массив.Напишите программу,
            //которая упорядочит по убыванию элементы каждой строки двумерного массива.

            Random random = new Random();
            int rows = random.Next(3, 8);
            int columns = random.Next(3, 8);
            int[,] array = new int[rows, columns];
            FillArray(array);
            PrintArray(array);
            SortRow(array);
            Console.WriteLine();
            PrintArray(array);
        }

        void Zadacha56()
        {
            //Задайте прямоугольный двумерный массив. Напишите программу,
            //которая будет находить строку с наименьшей суммой элементов.
            
            Random random = new Random();
            int rows = random.Next(6, 7);
            int columns = random.Next(2, 4);
            int[,] array = new int[rows, columns];
            FillArray(array, 0, 9);
            PrintArray(array);
            Console.WriteLine();

          
            
            for (int i = 0; i < rows; i++)
            {
                int sumRow = 0;
                int nextRow = 0;
                int MinRow = i; 

                for (int j = 0; j < columns; j++)
                {
                    sumRow += array[i, j];
                    Console.WriteLine($"sumRow {sumRow}");
                    nextRow += array[i+1, j];
                    Console.WriteLine($"nextRow {nextRow}");
                }

            if (sumRow > nextRow)
            {
                MinRow = i+1;
            }
            Console.WriteLine(MinRow);
            }

        }

        //Zadacha54();
        Zadacha56();
    }
    static void FillArray(int[,] array, int startNum = 0, int finishNum = 10)
    {
        Random random = new Random();
        finishNum++;
        int rows = array.GetLength(0);
        int columns = array.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                array[i, j] = random.Next(startNum, finishNum);
            }
        }
    }

    static void PrintArray(int[,] array)
    {
        int rows = array.GetLength(0);
        int columns = array.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(array[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    static void SortRow(int[,] array)
    {
        int rows = array.GetLength(0);
        int columns = array.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = columns - 1; j > 0; j--)
            {
                for (int k = 0; k < j; k++)
                {
                    if (array[i, k] < array[i, k + 1])
                    {
                        int temp = array[i, k];
                        array[i, k] = array[i, k + 1];
                        array[i, k + 1] = temp;
                    }
                }
            }
        }
    }
}