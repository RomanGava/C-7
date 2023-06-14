//_______________________________Задача 47______________________________________________
//  Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// Console.Write("Введите количество m(строк) массива: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество n(цифр) массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// double[,] randomArray = new double[m,n];

// mas(m,n);
// void mas(int m, int n)
// {
// int i,j;
// Random rand = new Random();
// for (i = 0; i < m; i++)
//     {
// Console.WriteLine();
// for (j = 0; j < n; j++)
//         {
//         randomArray[i,j] = rand.Next(-99, 100)/10;
//         Console.Write($"{randomArray[i,j]:F2} ");
//         }

//     }

// }


// ________________________________________________Задача 50________________________________________________
//  Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// Console.Write("Введите количество m(строк) массива:  ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество n(столбцов) массива:   ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите строку: ");
// int pos1 = Convert.ToInt32(Console.ReadLine()) - 1;
// Console.Write("Введите столбец: ");
// int pos2 = Convert.ToInt32(Console.ReadLine()) - 1;
// Random random = new Random();
// int[,] arr = new int[m,n];
// Console.WriteLine("Исходный массив:");
// for (int i = 0; i < arr.GetLength(0); i++)
// {
//    for (int j = 0; j < arr.GetLength(1); j++)
//      {
//         arr[i, j] = random.Next(1, 10);
//         Console.Write("{0} ", arr[i, j]);
//      }
//     Console.WriteLine();
// }
//  if (pos1 < 0 | pos1 > arr.GetLength(0) - 1 | pos2 < 0 | pos2 > arr.GetLength(1) - 1)
//  {
//     Console.WriteLine("Такого элемента в масиве нет");
// }
// else
// {
//     Console.WriteLine("Значение элемента массива = {0}", arr[pos1, pos2]);
// }

 
// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


// Console.Write("Введите количество m(строк) массива:  ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество n(столбцов) массива:   ");
// int n = Convert.ToInt32(Console.ReadLine());

// int[,] numbers = new int[m, n];

// void GenerateRandomArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
//         }
//     }
// }

// void PrintRandomArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine("");
//     }
// }

// void ArithmeticMean(int[,] array)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {   
//         double Result = 0;
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             Result += array[i, j];
//         }
//         Console.Write($"{Result / array.GetLength(0):F2} ");
//     }
// }

// GenerateRandomArray(numbers);
// PrintRandomArray(numbers);
// Console.WriteLine($" ");
// ArithmeticMean(numbers);
