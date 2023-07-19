/*
Выводим список от 1 до N
Используем рекурсию
*/


int ReadInt (string text)
{
    Console.WriteLine(text);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}



void Numbers (int N)
{
    if ( N == 0) return;
    Numbers(N-1);
    Console.Write(N + " ");
}



void Main()
{
    int N = ReadInt("Введите число");
    Numbers(N);
}

Main();


