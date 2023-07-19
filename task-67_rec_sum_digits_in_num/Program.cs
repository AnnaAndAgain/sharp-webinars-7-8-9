/*
Принимаем число
Считаем и выводим сумму цифр
*/



int ReadInt(string text)
{
    Console.WriteLine(text);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int SumDigits(int N)
{
    if (N == 0) return 0;
    return N % 10 + SumDigits(N / 10);
}


void Main()
{
    int N = ReadInt("Введите число");
    System.Console.WriteLine(SumDigits(Math.Abs(N)));
}

Main();



