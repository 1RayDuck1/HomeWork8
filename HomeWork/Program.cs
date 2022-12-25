//Домашняя работа.

//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

/*
double[,] CreateRandom2dArray()
{
    Console.Write("Введите количество столбцов: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество строк: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите минимальный размер элиментов: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите максимальный размер элиментов: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    double[,] array = new double[rows, columns];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}

void Show2dArray(double[,] array)
{
    Console.WriteLine();
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void Regulariz2dArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        double  min = array[i, 0];
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i,j] > min)
            {
                array[i,j - 1] = array[i, j];
                array[i, j] = min;
                min = array[i, 0];
                j = 0;
            }
            else min = array[i,j];
        }
    }
}

double[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
Regulariz2dArray(myArray);
Show2dArray(myArray);
*/

//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

/*
double[,] CreateRandom2dArray()
{
    Console.Write("Введите количество столбцов: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество строк: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите минимальный размер элиментов: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите максимальный размер элиментов: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    double[,] array = new double[rows, columns];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}

void Show2dArray(double[,] array)
{
    Console.WriteLine();
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

double FindMinSumRows(double[,] array)
{
    double[] minRows = new double[array.GetLength(0)];
    int index = 0;
    double minIndex = 0;
    for(int i = 0; i < array.GetLength(0); i++)
    {  
        double sum = 0;
        for(int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i,j];
        }
        minRows[index] = sum;
        index++;
    }
    index = 0;
    double min = minRows[0];
    while(index < minRows.Length)
    {
        if(min > minRows[index])
        {
            min = minRows[index];
            minIndex = index + 1;
        }
        index++;
    }
    Console.WriteLine(min);
    return minIndex;
}

double[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
double minRows = FindMinSumRows(myArray);
Console.WriteLine($"Строка с наименьшей суммой элиментво: {minRows} строка");
*/

//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

/*
double[,] CreateRandom2dArray()
{
    Console.Write("Введите минимальный размер элиментов: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите максимальный размер элиментов: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    double[,] array = new double[2, 2];

    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}

void Show2dArray(double[,] array)
{
    Console.WriteLine();
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

double[,] SumMatrix(double[,] array1, double[,] array2)
{
    double[,] newArray = new double[2, 2];
    newArray[0,0] = array1[0,0]*array2[0,0] + array1[0,1]*array2[1,0];
    newArray[0,1] = array1[0,0]*array2[0,1] + array1[0,1]*array2[1,1];
    newArray[1,0] = array1[1,0]*array2[0,0] + array1[1,1]*array2[1,0];
    newArray[1,1] = array1[1,0]*array2[0,1] + array1[1,1]*array2[1,1];
    return newArray;
}

double[,] myArray = CreateRandom2dArray();
double[,] array2 = CreateRandom2dArray();
double[,] sumMatrix = SumMatrix(myArray, array2);
Show2dArray(myArray);
Show2dArray(array2);
Show2dArray(sumMatrix);
*/

//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

/*
double[,] CreateRandom2dArray()
{
    int spirNum = 1;

    double[,] array = new double[4, 4];

    for(int j = 0; j < array.GetLength(1); j++)
    {
        array[0, j] = spirNum;
        spirNum++;
    }
    for(int i = 1; i < array.GetLength(0); i++)
    {
        array[i, 3] = spirNum;
        spirNum++;
    }
    for(int j = 2; j > -1; j--)
    {
        array[3, j] = spirNum;
        spirNum++;
    }
    for(int i = 2; i > 0; i--)
    {
        array[i, 0] = spirNum;
        spirNum++;
    }
    array[1,1] = spirNum;
    spirNum++;
    array[1,2] = spirNum;
    spirNum++;
    array[2,2] = spirNum;
    spirNum++;
    array[2,1] = spirNum;

    return array;
}

void Show2dArray(double[,] array)
{
    Console.WriteLine();
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

double[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
*/