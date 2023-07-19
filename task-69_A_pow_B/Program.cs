/*
Принимаем А и Вю
Возводим А в степень В
Используем рекурсию
*/


int ReadInt(string text)
{
    Console.WriteLine(text);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int Power(int A, int B)
{
    if (B == 0) return 1;
    return A * Power(A, B-1);
}


void Main()
{
    int A = ReadInt("Введите число");
    int B = ReadInt("Введите степень");
    Console.WriteLine(Power(A, B));
}

Main();


