using System.Numerics;

Console.Write("Введите число: ");
string? strNum = Console.ReadLine();
int timeStart = 0;
DateTime timePoint;
BigInteger sum = 0;

if (BigInteger.TryParse(strNum, out var number) == false)
{
    Console.WriteLine("Вы ввели не число");
}
else
{
    timeStart = Environment.TickCount;
    timePoint = DateTime.Now;
    sum = Sum10(BigInteger.Parse(strNum));
    Console.WriteLine($"Сумма чисел = {sum}. Время выполнения (вещ. числа) = {Environment.TickCount - timeStart}, {DateTime.Now - timePoint}");
    timeStart = Environment.TickCount;
    timePoint = DateTime.Now;
    sum = SumChar(strNum);
    Console.WriteLine($"Сумма чисел = {sum}. Время выполнения (массив символов) = {Environment.TickCount - timeStart}, {DateTime.Now - timePoint}");
}

// метод для подсчета суммы в вещественных числах
BigInteger Sum10(BigInteger num)
{
    BigInteger sum = 0;
    while (num > 0)
    {
        sum += num % 10;
        num /= 10;
    }

    return sum;
}

// метод для подсчета суммы в массиве символов
BigInteger SumChar(string strNum)
{
    BigInteger sum = 0;
    foreach (var c in strNum.ToCharArray())
    {
        sum = sum + int.Parse(c.ToString());
    }
    return sum;
}