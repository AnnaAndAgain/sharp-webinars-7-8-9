/*
Задаем двумерный массив из целых чисел.
Удаляем строку и столбец, на перечечении которых минимальный элемент.
*/



int[,] FillArrayRandom(int rows, int columns, int min, int max)
{
    int[,] result = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = rnd.Next(min, max);
        }
    }
    return result;
}

void PrintArray(int[,] tmpArray)
{
    for (int i = 0; i < tmpArray.GetLength(0); i++)
    {
        for (int j = 0; j < tmpArray.GetLength(1); j++)
        {
            Console.Write(tmpArray[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int ReadInt(string text)
{
    Console.WriteLine(text);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[] FindMinIndex(int[,] tmpArray)
{
    int[] result = new int[2];
    int min = tmpArray[0,0];

    for (int i = 0; i < tmpArray.GetLength(0); i++)
    {
        for (int j = 0; j < tmpArray.GetLength(1); j++)
        {
            if (tmpArray[result[0], result[1]] > tmpArray[i, j])
            {
                result[0] = i;
                result[1] = j;
            }
        }
    }
    return result;
}

int[,] DeleteRowColumn(int[,] tmpArray, int[] position)
{
    int[,] result = new int[tmpArray.GetLength(0) - 1, tmpArray.GetLength(1) - 1];

    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            if (i < position[0] && j < position[1])
            {
                result[i, j] = tmpArray[i, j];
            }
            else if (i >= position[0] && j < position[1])
            {
                result[i, j] = tmpArray[i + 1, j];
            }
            else if (i < position[0] && j >= position[1])
            {
                result[i, j] = tmpArray[i, j + 1];
            }
            else
            {
                result[i, j] = tmpArray[i + 1, j + 1];
            }
        }
    }
    return result;
}

void Main()
{
    int minV = 0;
    int maxV = 10;
    int[,] myArray = FillArrayRandom(ReadInt("Введите число строк:"), ReadInt("Введите число столбцов:"), minV, maxV);
    Console.WriteLine();
    PrintArray(myArray);
    Console.WriteLine();

    int[] index = FindMinIndex(myArray);
    Console.WriteLine(string.Join(", ", index));
    Console.WriteLine();
    PrintArray(DeleteRowColumn(myArray, index));
}

Main();