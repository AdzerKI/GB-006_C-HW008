/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */

// создает рандомный двумерный массив int
int[,] RandomArray (int firstArrayQuantity, int secondArrayQuantity, int minimum, int maximum) {
    int[,] array = new int[firstArrayQuantity, secondArrayQuantity];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j <  array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(minimum,maximum+1);
        }
    }

    return array; 
}

// возвращает строку из двумерного массива int
string ArrayIntToString(int[,] arr){
    string result = string.Empty;

    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {            
            result = result + $"{arr[i, j]} ";
        }
        result = result + $"\n";
    }

    return result;
}

// создаем массив
int[,] matrix = RandomArray(5,5,0,10);

// выводим массив
System.Console.WriteLine($"{ArrayIntToString(matrix)}"); 
System.Console.WriteLine();

for (int i = 0; i < matrix.GetLength(0); i++)
{
    int[] temp = new int[matrix.GetLength(1)];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {        
        temp[j] = matrix[i, j];
        Array.Sort(temp);
        for (int k = 0; k < matrix.GetLength(1); k++)
        {
            matrix[i, k] = temp[k];
        }

    }
}

// выводим массив
System.Console.WriteLine($"{ArrayIntToString(matrix)}"); 


/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7 
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

// создает рандомный двумерный массив int
int[,] RandomArray (int firstArrayQuantity, int secondArrayQuantity, int minimum, int maximum) {
    int[,] array = new int[firstArrayQuantity, secondArrayQuantity];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j <  array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(minimum,maximum+1);
        }
    }

    return array; 
}

// возвращает строку из двумерного массива int
string ArrayIntToString(int[,] arr){
    string result = string.Empty;

    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {            
            result = result + $"{arr[i, j]} ";
        }
        result = result + $"\n";
    }

    return result;
}

// создаем массив
int[,] matrix = RandomArray(5,5,0,10);

// выводим массив
System.Console.WriteLine($"{ArrayIntToString(matrix)}"); 
System.Console.WriteLine();

    int[] summ = new int[matrix.GetLength(0)];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        summ[i] = summ[i] + matrix [i, j];
    }
}

int low = 0;

for (int i = 0; i < summ.Length; i++)
{
    if (summ[low] > summ[i]){
        low = i;
    }
}

System.Console.WriteLine($"Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: {low + 1}");



/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

// создает рандомный двумерный массив int
int[,] RandomArray (int firstArrayQuantity, int secondArrayQuantity, int minimum, int maximum) {
    int[,] array = new int[firstArrayQuantity, secondArrayQuantity];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j <  array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(minimum,maximum+1);
        }
    }

    return array; 
}

// возвращает строку из двумерного массива int
string ArrayIntToString(int[,] arr){
    string result = string.Empty;

    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {            
            result = result + $"{arr[i, j]} ";
        }
        result = result + $"\n";
    }

    return result;
}

// создаем массив
int[,] matrixOne = RandomArray(2,2,0,10);
int[,] matrixTwo = RandomArray(2,2,0,10);

// выводим массив
System.Console.WriteLine($"{ArrayIntToString(matrixOne)}"); 
System.Console.WriteLine($"{ArrayIntToString(matrixTwo)}"); 

int[,] result = new int[matrixOne.GetLength(0), matrixTwo.GetLength(1)];

if (matrixOne.GetLength(1) == matrixTwo.GetLength(0))
{
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = 0;
            for (int n = 0; n < matrixOne.GetLength(1); n++)
            {
                result[i, j] += matrixOne[i, n] * matrixTwo[n, j];
            }
        }
    }
}

System.Console.WriteLine($"{ArrayIntToString(result)}"); 

/* Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */



/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */