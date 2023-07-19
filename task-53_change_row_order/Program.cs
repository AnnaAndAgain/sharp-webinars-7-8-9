/*
53.
Задаем двумерный массив.
Меняем местами первую и последнюю строки.
*/

int[,] FillArrayRandom(int rows, int columns, int min, int max)
{
    int[,] result = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j =0; j < columns; j++)
        {
            result[i, j] = rnd.Next(min, max);
        }
    }
    return result;
}

void PrintArray(int[,] tmpArray)
{
    
    for (int i = 0; i< tmpArray.GetLength(0); i++)
    {
        for (int j = 0; j < tmpArray.GetLength(1); j++)
        {
            Console.Write($"{tmpArray[i, j]} ");
        }
        Console.WriteLine();
    }  
}

void ChangeFirstLastRows(int[,] tmpArray)
{
    int tmp = 0;
    for (int i=0; i<tmpArray.GetLength(1); i++)
    {
        tmp = tmpArray[0, i];
        tmpArray[0, i] = tmpArray[tmpArray.GetLength(0)-1, i];
        tmpArray[tmpArray.GetLength(0)-1, i] = tmp;
    }
}

void Main()
{
    int[,] myArray = FillArrayRandom(10, 13, 0, 10);
    PrintArray(myArray);
    System.Console.WriteLine();
    ChangeFirstLastRows(myArray);
    PrintArray(myArray);
}

Main();