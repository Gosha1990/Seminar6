//  Задача 39: Напишите программу, которая перевернёт
//   одномерный массив (последний элемент будет на первом месте,
//    а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// // [6 7 3 6] -> [6 3 7 6]


//FillArray ; размер , мин и мах - GetArray(методы)
// int[] array = FillArray(10,0,10);
// Console.WriteLine($"Исходный масив: [{String.Join(" ; ", array)}]");
// int[] FillArray(int size, int minValue ,int maxValue)
// {
//     int[] result = new int[size];
//     for( int i = 0; i < size; i++)
//     {
//         result[i] = new Random().Next(minValue,maxValue + 1);  
//     }
//     return result;
// }
// Console.WriteLine();
// int[] resultArray = CopyArray(array);
// Console.WriteLine($"Перевернутый масив: [{String.Join(" ; ",resultArray)}]");
// int[] CopyArray(int[] inputArray)
// {
//     int size = inputArray.Length;
//     int[] inversArray = new int[size];
//     for( int i = 0; i < size; i++)
//     {
//     inversArray[i] = inputArray[size - 1 - i];
//     }
//     return inversArray;
// }



// // С помощью доп.Переменной

// void ReversArray(int[] arr)
// {
//     for(int i = 0; i < arr.Length / 2; i++)
//     {
//     int temp = arr[i];
//     arr[i] = arr[arr.Length  -1 -i];
//     arr[arr.Length  -1 -i] = temp;
//     }

// }
// Console.WriteLine("Переворот через метод VOID");
// ReversArray(array);
// Console.WriteLine($"Перевернутый масив: [{String.Join(" ; ", array)}]");



//самостоятельная работа

// // Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// // Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.
// Console.WriteLine("Введите число a: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число b: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число c: ");
// int c = Convert.ToInt32(Console.ReadLine());
// /*string CheckSum(int a, int b, int c)
// {   
//  if (a + b > c && b + c > a && a + c > b)   
// {        
// return "Треугольник существует";    
// }    
// else   
// {      return "Треугольник НЕ существует";   
// }
// }
// */
// // System.Console.WriteLine(CheckSum(value1, value2, value3));
// System.Console.WriteLine((a + b > c && b + c > a && a + c > b)?"Треугольник существует":"Треугольник НЕ существует");



//   int Fibonacci(int n)
// {
//  if(n == 1 || n == 2) return 1;
//  else return Fibonacci(n-1) + Fibonacci(n-2);
// }
// for (int i = 1; i < 10; i++)
// {
//  Console.WriteLine(Fibonacci(i));


// Console.WriteLine("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// int count = 1;
// int size = count;
// int[] array = new int[size]; // <- вот здесь надо указать размер массива
// int temp = 0;
// // Число постоянно делим на 2 и остаток от деления (0 или 1) записываем с конца в начало
// // Нам нужно делить на два и результат куда то записывать, например в массив, точнее в массив
// // А есть какая нибудь команда мб для указания произвольного размера массива?
// // можно указать size как 0, а потом при нахождении нового числа от деления менять размер массива. Как вам идея?
// for (int i = 0; i < size; i++)
// {
//     while (a > 2)
//     {
//         temp = a % 2;
//         a = a / 2; 
//     }
//     array[i] = temp;
//     // size++;
// }
// Console.WriteLine($"[{String.Join("; ", array)}]");


// int a = 35;

// int b = 4;

// int c = 5;

// bool IsTrinagle(int a, int b, int c)
// {
//     return (a + b > c && a + c > b && b + c > a); // False - треугольник не существует, True - существует
// }

// Console.WriteLine(IsTrinagle(a,b,c));



// Не используя рекурсию, выведите первые N чисел Фибоначчи.
//  Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

int countFibonacci = 5;
int firstFibonacci = 0;     // Первое число Фибоначчи
int secondFibonacci = 1;    // Второе число Фибоначчи

Console.WriteLine($"1. {firstFibonacci}");  // i = 1
Console.WriteLine($"2. {secondFibonacci}"); // i = 2

for (int i = 3; i <= countFibonacci; i++)
{
    int nextFibonacci = firstFibonacci + secondFibonacci;
    Console.WriteLine($"{i}. {nextFibonacci}");
    firstFibonacci = secondFibonacci;
    secondFibonacci = nextFibonacci;
}