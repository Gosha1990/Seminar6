// Напишите программу, которая выводит случайное число из 
// отрезка [10, 99] и показывает наибольшую цифру числа.
// 78 -> 8 
// 12-> 2 
// 85 -> 8


// int number = new Random().Next(0,11); первый параметр
// int number = new Random().Next(11); одинаково с верхней строчкой
// 
// int firstValue = number / 10; //первая цифра нашего чиста(78/10=7)
// int secondValue = number % 10; //вторая цифра : 78 % 10 =8 остаток (78- 7*10 = 78 - 70 =8)
// int max = firstValue;
// if (secondValue > max)
// {
// max = secondValue;
// }

//Console.WriteLine("максимальная цифра в числе: " + number, " - это", + max);






// 11. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98
//number/100*10+number%10


// int number = new Random().Next(100,1000);//[100-999]
// int result = (number/100) * 10 + number % 10; //для числа 478 : (number / 100)*10=4*10

// Console.WriteLine("Исходное число " + number + "; 1 и 3 цифра: " + result);

// string message = Console.ReadLine





// Напишите программу, которая будет принимать на вход два числа и выводить,
//  является ли второе число кратным первому. Если число 2 не кратно числу 1, 
//  то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

// Console.Write("Введите первое число: ");
// int firstNumber = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите втоирое число: ");
// int secondNumber = Convert.ToInt32(Console.ReadLine());
// if (secondNumber == 0)
// {
//  return;
// }

// if (firstNumber % secondNumber == 0)
// {
// Console.WriteLine("кратно!");
// }
// else
// {
//     Console.WriteLine("НЕ кратно, очтаток от  деления равен"  + firstNumber % secondNumber );
// 




// 14. Напишите программу, которая принимает 
// на вход число и проверяет, 
// кратно ли оно одновременно 7 и 23.
// 14 -> нет 
// 46 -> нет 
// 161 -> 

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
// "&&" и то и другое берем одновременноъ
// "||" одно истиное значение
 if (number % 7 == 0 && number % 23 == 0)
 {
 Console.WriteLine("Число одновременно кратное и 7 и 23");

 }
else
  {
  Console.WriteLine("Число одновременно не кратное и 7 и 23");
  Console.WriteLine($"Остаток от деления на 7 равен : {number % 7}");
  Console.WriteLine($"Остаток от деления на 23 равен : {number % 23}");
  }

