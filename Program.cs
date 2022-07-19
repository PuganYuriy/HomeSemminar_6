// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// double[,] generateRandomArrayFloat(int n, int m) // создание функции для создания двухмерного массива
// {
//     double[,] randomArray = new double [n, m];
//     for (int i = 0; i < n; i++)
//     {
//         for (int j = 0; j < m; j++)
//         {
//             randomArray[i, j] = new Random().NextDouble() * 100 - 10; //заполнение массива случайными числами
            
//         }
//     }
//     return randomArray;
// }

// void printRandomArray(double [,] array) // создание метода для вывода массива на консоль
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             double bitВepth = Math.Round (array [i, j], 2);
//             Console.Write($"{bitВepth}; ");
//         }
//     Console.WriteLine(" ");
//     }
// }
// Console.Clear();
// Console.WriteLine("Задайте двумерный массив размером m и n, заполненный случайными вещественными числами");
// Console.Write("Введите количество строк массива: ");
// int rows=Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите количество столбцов массива: ");
// int columns=Convert.ToInt32(Console.ReadLine());

// Console.Write($"m = {rows}, ");
// Console.Write($"n = {columns}");
// Console.WriteLine(" ");
// double[,] array = generateRandomArrayFloat(rows, columns);
// printRandomArray(array);

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// int [,] generateRandomArray(int z, int x, int minNumber, int maxNumber) // создание функции для создания двухмерного массива
// {
//     int [,] rnArray = new int [z, x];
//     for (int i = 0; i < z; i++)
//     {
//         for (int j = 0; j < x; j++)
//         {
//             rnArray[i, j] = new Random().Next(minNumber, maxNumber); //заполнение массива случайными числами
//         }
//     }
//     return rnArray;
// }

// void printArray(int [,] prArray) // создание метода для вывода массива на консоль
// {
//     for (int i = 0; i < prArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < prArray.GetLength(1); j++)
//         {
//             Console.Write($"{prArray[i, j]} ");
//         }
//     Console.WriteLine(" ");
//     }
// }


// Console.Clear();
// Console.Write("Введите количество строк массива: ");
// int rows1=Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите количество столбцов массива: ");
// int columns1=Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите минимальное число массива: ");
// int min=Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите максимальное число массива: ");
// int max=Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите номер строки который нужны вывести: ");
// int number1=Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите номер столбца который нужны вывести: ");
// int number2=Convert.ToInt32(Console.ReadLine());

// int [,] array1 = generateRandomArray (rows1, columns1, min, max);
// printArray(array1);

// Console.WriteLine("-----------------");
// Console.Write ($"В индексе строки {number1} и индексе столба {number2}");

// if (number1 < array1.GetLength(0) && number2 < array1.GetLength(1))
//     {
//         Console.Write ($"-> {array1[number1, number2]}");
//     }
// else
//     {
//         Console.Write ($"-> такого индекса в массиве нет");
//     }

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int [,] generateRandomArray1(int z, int x, int minNumber, int maxNumber) // создание функции для создания двухмерного массива
{
    int [,] rnArray = new int [z, x];
    for (int i = 0; i < z; i++)
    {
        for (int j = 0; j < x; j++)
        {
            rnArray[i, j] = new Random().Next(minNumber, maxNumber); //заполнение массива случайными числами
        }
    }
    return rnArray;
}

void printArray1(int [,] prArray) // создание метода для вывода массива на консоль
{
    for (int i = 0; i < prArray.GetLength(0); i++)
    {
        for (int j = 0; j < prArray.GetLength(1); j++)
        {
            Console.Write($"{prArray[i, j]} ");
        }
    Console.WriteLine(" ");
    }
}

void mediumArray(int [,] mdArray) // создание метода для вывода средне арифмитического
{
    double midiumColumns = 0.00;
    for (int i = 0; i < mdArray.GetLength(1); i++)
    {
        for (int j = 0; j < mdArray.GetLength(0); j++)
        {
            midiumColumns = midiumColumns + mdArray[j,i];
        }
    Console.WriteLine($"{midiumColumns/mdArray.GetLength(1):f2} ");
    }
}

Console.Clear();
Console.Write("Введите количество строк массива: ");
int rows2=Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int columns2=Convert.ToInt32(Console.ReadLine());

Console.Write("Введите минимальное число массива: ");
int min1=Convert.ToInt32(Console.ReadLine());

Console.Write("Введите максимальное число массива: ");
int max1=Convert.ToInt32(Console.ReadLine());

int [,] array2 = generateRandomArray1 (rows2, columns2, min1, max1);
printArray1(array2);
Console.WriteLine("Среднее арифметическое каждого столбца -> ");
mediumArray(array2);