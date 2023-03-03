// Задача 46: Задайте двумерный массив размером m×n,
//  заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

// матрица - таблица ,размерность m строк и n столбцов
// int[,] GetMatrix(int rows, int cols, int minValue, int maxValue)
// {
//     int[,] matrix = new int[rows, cols];  //[строчка. столбец]
//     for (int i = 0; i < rows; i++)// строчки; rows = matrix.GetLenght(0)
//     {
//         for (int j = 0; j < cols; j++)
//         {
//             matrix[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return matrix;
// }
// void PrintMatrix(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)// проход по строчкам
//     {
//         for (int m = 0; m < matr.GetLength(1); m++)//проход по столбцам
//         {
//             Console.Write(matr[i, m] + "\t");
//         }
//         Console.WriteLine();// перенос на новую строчку
//     }
// }
// int[,] resultMatrix = GetMatrix(3, 4, 0, 10);
// PrintMatrix(resultMatrix);







// Задача 48: Задайте двумерный массив размера m на n, 
// каждый элемент в массиве находится по формуле: Aₘₙ = m+n. 
// Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5


// int[,] GetMatrix(int rows, int cols)
// {
//     int[,] matrix = new int[rows, cols];  //[строчка. столбец]
//     for (int i = 0; i < rows; i++)// строчки; rows = matrix.GetLenght(0)
//     {
//         for (int j = 0; j < cols; j++)
//         {
//             matrix[i, j] = i + j ;
//         }               
//     }   
//     return matrix;
// }
// void PrintMatrix(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)// проход по строчкам
//     {
//         for (int m = 0; m < matr.GetLength(1); m++)//проход по столбцам
//         {
//             Console.Write(matr[i, m] + "\t");
//         }
//         Console.WriteLine();// перенос на новую строчку
//     }
// }
// int[,] resultMatrix = GetMatrix(3, 4);         
// PrintMatrix(resultMatrix);








// Задача 49: Задайте двумерный массив.
//  Найдите элементы, у которых оба индекса чётные, 
//  и замените эти элементы на их квадраты.

int[,] GetMatrix(int rows, int cols,int minValue, int maxValue)
{
    int[,] matrix = new int[rows, cols];  //[строчка. столбец]
    for (int i = 0; i < rows; i++)// строчки; rows = matrix.GetLenght(0)
    {
        for (int j = 0; j < cols; j++)
        {
            matrix[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return matrix;
}
int[,] ChangeMatrix(int[,] inputMatrix)
{
    //if(!(i%2)&&!(j%2))
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int k = 0; k < inputMatrix.GetLength(1); k++)
        {
            if (i % 2==0 && k % 2== 0)
            {
                inputMatrix[i,k]*= inputMatrix[i,k];
            }
        }
    }
    return  inputMatrix;
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)// проход по строчкам
    {
        for (int m = 0; m < matr.GetLength(1); m++)//проход по столбцам
        {
            Console.Write(matr[i, m] + "\t");
        }
        Console.WriteLine();// перенос на новую строчку
    }
}
int[,] resultMatrix = GetMatrix(3, 4,0,10);
PrintMatrix(resultMatrix);
Console.WriteLine("Дальше матрица с квадратами: ");
PrintMatrix(ChangeMatrix(resultMatrix));
