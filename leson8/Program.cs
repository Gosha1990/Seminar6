
// string correctString = String.Empty; // пустая строчка


// int inputNumber;






// int[] array ={10,50,100,200,500,1000,2000,5000};

// //int max = array[0];// int max = int.MinValue
// int max = int.MinValue;
// int min = int.MaxValue;







// // vЗадача 53: Задайте двумерный массив. Напишите программу,
// //  которая поменяет местами первую и последнюю строку массива.
// int[,] resultMatrix = GetMatrix(5, 5, 0, 10);

// PrintMatrix(resultMatrix);

// Console.WriteLine("это результирующая матрица: ");
// ChangeRows(resultMatrix);
// PrintMatrix(resultMatrix);

// /// <summary>
// /// этот метод заполняет двумерный масив 
// /// числами от min до max(общее описание)
// /// </summary>
// /// <param name="rows">Количество строк</param>
// /// <param name="cols">Количество столбцов</param>
// /// <param name="min">Минимальное число для рандома</param>
// /// <param name="max">Максимальное число для рандома</param>
// /// <returns>Заполненый масив целых чисел</returns>
// int[,] GetMatrix(int rows, int cols, int min, int max)
// {
//     int[,] matrix = new int[rows, cols];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < cols; j++)
//         {
//             matrix[i, j] = new Random().Next(min, max + 1);
//         }
//     }


//     return matrix;
// }
// /// <summary>
// /// Метод печатает матрицу , которуе передали на вход
// /// </summary>
// /// <param name="inputMatrix">двумерный масив или таблица</param>
// void PrintMatrix(int[,] inputMatrix)
// {
//     for (int i = 0; i < inputMatrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < inputMatrix.GetLength(1); j++)
//         {
//             Console.Write(inputMatrix[i, j] + "\t");
//         }
//         Console.WriteLine();
//     }
// }

// //Метод PascalCase
// // camelCase
// /// <summary>
// /// Метод ищет пследнюю строчку и меняет с первой местами
// /// </summary>
// /// <param name="matr"> маирица или двумерный масив</param>
// void ChangeRows(int[,] matr)
// {
//     int lastRows = matr.GetLength(0) - 1;
//     for (int i = 0; i < matr.GetLength(1); i++)
//     {
//         int temp = matr[0, i];
//         matr[0, i] = matr[lastRows, i];
//         matr[lastRows, i] = temp;
//     }
// }



//=================================================================






// Задача 55: Задайте двумерный массив. Напишите программу,
//  которая заменяет строки на столбцы. В случае, если это невозможно,
//  программа должна вывести сообщение для пользователя.


// int rows = 4;
// int cols = 4;
// if (rows != cols)
// {
//     System.Console.WriteLine(" не возможео");
//     return;
// }

// int[,] resultMatrix = GetMatrix(5, 5, 0, 10);
// PrintMatrix(resultMatrix);
// System.Console.WriteLine("gthdfz");

// PrintMatrix(ChangeRows(resultMatrix));
// /// <summary>
// /// этот метод заполняет двумерный масив 
// /// числами от min до max(общее описание)
// /// </summary>
// /// <param name="rows">Количество строк</param>
// /// <param name="cols">Количество столбцов</param>
// /// <param name="min">Минимальное число для рандома</param>
// /// <param name="max">Максимальное число для рандома</param>
// /// <returns>Заполненый масив целых чисел</returns>
// int[,] GetMatrix(int rows, int cols, int min, int max)
// {
//     int[,] matrix = new int[rows, cols];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < cols; j++)
//         {
//             matrix[i, j] = new Random().Next(min, max + 1);
//         }
//     }


//     return matrix;
// }
// /// <summary>
// /// Метод печатает матрицу , которуе передали на вход
// /// </summary>
// /// <param name="inputMatrix">двумерный масив или таблица</param>
// void PrintMatrix(int[,] inputMatrix)
// {
//     for (int i = 0; i < inputMatrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < inputMatrix.GetLength(1); j++)
//         {
//             Console.Write(inputMatrix[i, j] + "\t");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] ChangeRows(int[,] matr)
// {
//     int[,] copyMatr = new int[matr.GetLength(0), matr.GetLength(1)];
//     for (int i = 0; i < copyMatr.GetLength(0); i++)
//     {
//         for (int j = 0; j < copyMatr.GetLength(1); j++)
//         {
//             copyMatr[i, j] = matr[j, i];
//         }

//     }
//     return copyMatr;
// }





//============================================================================





int rows = 3;
int cols = 3;
int[,] matrix = new int[rows,cols];
int min = int.MaxValue;
int indexMinRows = 0;
int indexMinCols = 0;

for (int i = 0; i <rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        matrix[i,j] = new Random().Next(11);
        System.Console.Write(matrix[i,j] + "\t");
        if(min > matrix[i,j])
        {
        min = matrix[i,j];
        indexMinRows = i;
        indexMinCols = j;
        }
    } 
    System.Console.WriteLine();
}
Console.WriteLine($"Мин.элемент: {min}, \t строчка: {indexMinRows}, \t cтолб: {indexMinCols}");

for (int i = 0; i < rows; i++)
{
    if(i != indexMinRows)
    {
        for (int j = 0; j < cols; j++)
        {
            if (j != indexMinCols)
            {
                Console.Write(matrix[i,j] + "\t");
            }
        }
        Console.WriteLine();
    }
}