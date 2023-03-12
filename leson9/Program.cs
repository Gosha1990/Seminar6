// //Унарные операторы - один оператор
// int a = 5;
// a++;
// a--;
// -a;


// // Бинарный операторы
// int a = 5 + 2;
// int b = 5 % 2;


// // Постфикс : " после"
// // Префиксный оператор: " перед " ++а
// int a = 1;
// int prefixIncrement = ++a * a;
// System.Console.WriteLine(prefixIncrement);
// int b = 3;
// int postfixIncrement = b++ * b;
// System.Console.WriteLine(postfixIncrement);


//Тернарный оператор:
//условие - 1 операнд? значение для истины -2: значение для лжи -3

// int dreamSalary = int.MaxValue;
// int realSalary = 50000;
// var  result = realSalary < dreamSalary ?"Пока что ЗП не большая" : "Наша зарплата: 2423458754";
// System.Console.WriteLine(result);


// string SayHello()
// {
//     SayHello();
//     return "Hi";

// }
// SayHello();

// while(true)
// {
// System.Console.WriteLine("hi");
// }






// int Factorial(int n)
// {
// //Базовый случай - случай выхода из рекурсии
// if(n == 1) return 1;
// // Рекурсивный случай - задание рекурсии (вызов функции внутри функции)
// return n * Factorial(n-1);
// }
// System.Console.WriteLine(Factorial(16));





// Задача 63: Задайте значение N. Напишите программу,
//  которая выведет все натуральные числа в промежутке 
//  от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

// Console.Write("Введите число N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// /// <summary>
// /// печатаем все натуральные числа в промежутке от 1 до N.
// /// </summary>
// /// <param name="start">от 1</param>
// /// <param name="end"> N = end</param>
// /// <returns></returns>
// string PrintNumbers(int start, int end)
// {
//     //Базовый 
//     if (start == end) return start.ToString();
//     // Рекурсивный 
//     return (start + "," + PrintNumbers(start + 1, end));
// }
// System.Console.WriteLine(PrintNumbers(1,N));

//=======================================================================


// Задача 67: Напишите программу, которая будет 
// принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9



//  Console.Write("Введите число N: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int SumNumbers(int num)
// {
// if(num==0)return 0;
// //Рекурсивный
// return(num % 10 + SumNumbers(num / 10));

// }
//  System.Console.WriteLine(SumNumbers(number));


//===========================================================================


// Задача 69: Напишите программу, которая на вход 
// принимает два числа A и B, и возводит число А в 
// целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8



Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());


Console.Write("Введите cтепень: ");
int degree = Convert.ToInt32(Console.ReadLine());

int GetPower(int number, int power)
{
    if (degree == 1) return number;
    if (power == 0) return 1;
    return (number * GetPower(number, power - 1));

}
Console.WriteLine(GetPower(number,degree));