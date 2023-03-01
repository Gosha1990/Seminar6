﻿// Задача 33: Задайте массив. Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да
int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
int foundNumber = new Random().Next(11); // [0;10]
string isFind = "НЕ НАЙДЕНО"; // Число икскомое не найдено
for (int i = 0; i < array.Length; i++)
{
if (array[i] == foundNumber)
{
isFind = "НАЙДЕНО";// Число найдено
break; // Ломает цикл при нахождении искомого числа
}
}
Console.WriteLine($"Число {foundNumber}: {isFind}");
// Задача 35: Задайте одномерный массив из 123 случайных чисел.
//  Найдите количество элементов массива,
//   значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. 
// В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5
int size = 123;
int[] array = new int[size];

int count = 0; // Количество чисел в д-е от 10 до 99 включительно

for (int i = 0; i < size; i++)
{
array[i] = new Random().Next(200); // [0,999]
if (array[i] >= 10 && array[i] <= 99)
{
count++; // Инкремент: count = count + 1
// count += 1
}
}
Console.WriteLine($"Массив: [{String.Join("; ", array)}]");
Console.WriteLine($"Число элементов, входящих в диапазон [10,99]: {count}");