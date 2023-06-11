// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными
// числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


// int InputNumber()
// {
//     int num = Convert.ToInt32(Console.ReadLine());
//     return num;
// }
// void CraeteArray(double[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             arr[i, j] = Math.Round((new Random().NextDouble() * 10), 1);
//         }
//     }
// }
// void PrintArray(double[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             Console.Write($"{arr[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// Console.Write("Введите число M: ");
// int row = InputNumber();
// Console.Write("Введите число N: ");
// int colums = InputNumber();

// double[,] array = new double[row, colums];
// CraeteArray(array);
// PrintArray(array);

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// int InputNumber()
// {
//     int num = Convert.ToInt32(Console.ReadLine());
//     return num;
// }
// void CraeteArray(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             arr[i, j] = new Random().Next(0, 50);
//         }
//     }
// }
// void PrintArray(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             Console.Write($"{arr[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }
// string SerchNumber(int[,] arr, int number)
// {
//     string mesSerch = "такое число в массиве есть";
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             if (number == arr[i, j])
//             {
//                 return mesSerch;
//             }
//         }
//     }
//     return mesSerch = "такого числа в массиве нет";
// }
// Console.Write("Введите число M: ");
// int row = InputNumber();
// Console.Write("Введите число N: ");
// int colums = InputNumber();

// int[,] array = new int[row, colums];
// CraeteArray(array);
// PrintArray(array);

// Console.Write("Введите число для поиска: ");
// int numberSearch = InputNumber();
// System.Console.WriteLine(SerchNumber(array, numberSearch));

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int InputNumber()
{
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
void CraeteArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0, 99);
        }
    }
}
void PrintArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}
void CearcAverage(double[,] arr)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        double average = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            average = average + arr[i, j] / arr.GetLength(1);
        }
        Console.WriteLine($"Средне арифметическое = {Math.Round(average, 1)}");
    }
}
Console.Write("Введите число M: ");
int row = InputNumber();
Console.Write("Введите число N: ");
int colums = InputNumber();

double[,] array = new double[row, colums];
CraeteArray(array);
PrintArray(array);
CearcAverage(array);