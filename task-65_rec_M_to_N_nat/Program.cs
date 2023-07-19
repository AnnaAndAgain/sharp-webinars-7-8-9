/*
Выводим список от M до N
Используем рекурсию

!!! Проверяем, чтобы пользователь ввел коррекные числа
*/


int ReadInt (string text)
{
    Console.WriteLine(text);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}



void Numbers (int M, int N)
{
    if (M > N) return;
    Console.Write(M + " ");
    Numbers(M+1, N);
}

bool CheckInputNumbers (int M, int N)
{
    if (M < N) return true;
    else return false;
}

void Main()
{
    int M = ReadInt("Введите меньшее число");
    int N = ReadInt("Введите большее число");
    if (CheckInputNumbers(M, N))
    {
        Numbers(M, N);
    }
    else 
    {
        Numbers(N, M);
    }
}

Main();

