internal class Program
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

            int[] result = new int[rows];
            for (int i = 0; i < rows; i++)
            {
                int sumRow = 0;
                for (int j = 0; j < columns; j++)
                {
                    sumRow += array[i, j];
                }
                result[i] = sumRow;
            }
            
            int min = 0;
            for (int k = 0; k < result.Length; k++)
            {
                if (result[min] > result[k+1])
                {
                    min = k+1;
                    Console.WriteLine();
                    Console.WriteLine($"{min+1} строка имеет минимальную сумму элементов");
                    Console.WriteLine();
                }
            }
        }

        void Zadacha58()
        {
            //Заполните спирально массив 4 на 4 числами от 1 до 16.

            Random random = new Random();
            int rows = random.Next(4, 5);
            int columns = random.Next(4, 5);
            int[,] array = new int[rows, columns];

            rows = array.GetLength(0);
            columns = array.GetLength(1);
            int s = 1;
            for (int j = 0; j < columns; j++)
            {
              array[0, j] = s;
              s++;
            }
            for (int i = 1; i < rows; i++)
            {
               array[i, columns-1] = s;
               s++;
            }
            for (int j = columns - 2; j > -1; j--)
            {
                array[rows-1, j] = s;
                s++;
            }
            for (int i = rows-2; i > 0; i--)
            {
                array[i, 0] = s;
                s++;
            }

            int k = 1;
            int l = 1;

            while (s < rows*columns)
            {
                while (array[k, l+1]  == 0)
                {
                    array[k,l] = s;
                    s++;
                    l++;
                }
                while (array[k+1, l] == 0)
                {
                    array[k,l] = s;
                    s++;
                    k++;
                }
                while (array[k, l-1] == 0)
                {
                    array[k,l] = s;
                    s++;
                    l--;
                }
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (array[i,j] == 0)
                    {
                        array[i,j] = s;
                    }
                }
            }
            
            PrintArray(array);
        }

        //Zadacha54();
        //Zadacha56();
        Zadacha58();
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
        static void PrintArray(int[] result)
    {
        int size = result.Length;

        for (int i = 0; i < size; i++)
        {
            Console.Write(result[i] + "\t");
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