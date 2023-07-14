/*
55.
Задаем двумерный массив.
Меняем строки на столбцы или выводим ошибку, если невозможно.
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
            Console.Write(tmpArray[i, j] + "\t");
        }
        Console.WriteLine();
    }  
}

int ReadInt (string text)
{
    Console.WriteLine(text);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

/*
//для ТЗ: только квадратные, иначе ошибка, с перезаписью матрицы
bool CheckTranspondability(int[,] tmpArray)
{
    if (tmpArray.GetLength(0)==tmpArray.GetLength(1)) return true;
    else return false;
}

int[,] TranspondArray(int[,] tmpArray)
{
    int[,] result = new int[tmpArray.GetLength(0), tmpArray.GetLength(1)];
    for (int i = 0; i < tmpArray.GetLength(0); i++)
    {
        for (int j = 0; j < tmpArray.GetLength(0); j++)
        {
            result[i, j] = tmpArray[j, i];
        }
    }
    return result;
}

void Main()
{
    int[,] myArray = FillArrayRandom(ReadInt("Введите число строк:"), ReadInt("Введите число столбцов:"), 0, 10);
    PrintArray(myArray);
    Console.WriteLine();
    if (CheckTranspondability(myArray)) 
    {
        int[,] transponded = TranspondArray(myArray);
        PrintArray(transponded);
    }
    else Console.WriteLine("В этом массиве нельзя поменять местами строки и столбцы.");
}
*/

//для прямоугольных матриц, без сообщений об ошибке
int[,] TranspondArrayRect(int[,] tmpArray)
{
    int[,] result = new int[tmpArray.GetLength(1), tmpArray.GetLength(0)];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = tmpArray[j, i];
        }
    }
    return result;
}

void Main()
{
    int[,] myArray = FillArrayRandom(ReadInt("Введите число строк:"), ReadInt("Введите число столбцов:"), 0, 10);
    PrintArray(myArray);
    Console.WriteLine();
    int[,] transponded = TranspondArrayRect(myArray);
    PrintArray(transponded);
}

Main();