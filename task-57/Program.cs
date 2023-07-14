/*
57. Составляем частотный словарь элементов двумерного массива.
(Сколько раз встречается каждый элемент)
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

void PrintDictionary(int[,] tmpArray)
{
    
    for (int i = 0; i < tmpArray.GetLength(1); i++)
    {
        Console.Write($"{tmpArray[0, i]} встречается {tmpArray[1, i]} раз(а)");
    }  
}

int[,] CreatreDictionary (int[,] tmpArray)
{
    int[,] result = new int[2, CountUnique(tmpArray)];
}

int CountUnique(int[,] tmpArray)
{
    hjg
}

void Main()
{
    int[,] myArray = FillArrayRandom(ReadInt(3, 3, 0, 10);
    PrintArray(myArray);
    Console.WriteLine();
    int[,] transponded = TranspondArrayRect(myArray);
    PrintArray(transponded);
}

Main();