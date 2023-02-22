// void: нет оператора return 

// тип Возвращаемого значения имя и (параметры 0

// int Calculate(int a, int b, char sign)  // два числа : а и в  параметр : знак(*;/)
// {
// int result = 0;
// // для чара одинарные ковычки  'd'
// if (sign == '*')
//     {
//     result = a * b;
//     }
//     else if (sign == '+')
//     {
//     result = a + b;
//     }
//  else if (sign == '-')
//     {
//     result = a - b;
//     }
//     else
//     {
//     Console.WriteLine("Обработка искл: такого знака нет");
//     }
// return result;
// }
//  Console.WriteLine(Calculate (1,2, '+'));
//  Console.WriteLine(Calculate (3,2, '-'));
//   Console.WriteLine (Calculate (100,35, '*'));
//   Console.WriteLine(Calculate (100,35, '_'));






// Напишите программу, которая принимает на вход 
// число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

// // 1. Без метода
// Console.Write("Введите число А: ");

// int limit = Convert.ToInt32(Console.ReadLine());
// int sum = 0;
// for (int i = 1; i <= limit; i++)
// {
// sum += i;
// }
// Console.WriteLine($"Сумма чисел от 1 до {limit} = {sum}");


// 2 хардкор

// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// int GetSum(int A)
// {
// int sum = 0;
// for (int i = 1; i <= limit; i++)
// {
// sum+=i;
// }
// return sum;

// }
// Console.WriteLine($"Сумма чисел от 1 до { limit} = {GetSum(limit)}");



// Задача 26: Напишите программу, которая принимает 
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5







// Задача 28: Напишите программу, которая принимает на 
// вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120
// Console.WriteLine("Введите число A: ");
// int factorial = Convert.ToInt32(Console.ReadLine());
// int GetSum(int A)
// {
//     int sum = 1;
//     for (int i = 1; i <= factorial; i++)
//     {
//         sum = sum * i; 
//     }
//     return sum;
// }
// Console.WriteLine($"Факториал числа {factorial} = {GetSum(factorial)}");


// Задача 30: Напишите программу, которая выводит
//  массив из 8 элементов, заполненный нулями и
//   единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]



// Random rnd = new Random();
// int value = rnd.Next(0, 2);
// int[] GetBinaryArray(int size)

// {
// int[] array = new int[size];
// for(int i = 0; i< size; i++)
// {
// array[i] = new Random().Next(2);
// }
// return array;
// }
// int[] resultArray = GetBinaryArray(8);

// double[] test = new double[10]; 

// for (int i = 0; i < resultArray.Length; i++)
// {
//     Console.Write(resultArray[i] + "\t"); 
// }



// второй вывод


// Console.WriteLine($"Массив: [{String.Join(";", resultArray)}  ]");