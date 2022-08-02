Console.Write("Введите число: ");
string? inputLine = Console.ReadLine();
int inputNum = int.Parse(inputLine);
int t = Environment.TickCount;

Console.WriteLine(mulNums(inputNum));
Console.WriteLine("Время выполнения: {0} мс", Environment.TickCount - t);

t = Environment.TickCount;
Console.WriteLine(mulRec(inputNum));
Console.WriteLine("Время выполнения: {0} мс", Environment.TickCount - t);

int mulNums(int num)
{
    int sum = 1;
    for (int i = 1; i <= inputNum; i++)
    {
        sum *= i;
    }
    return sum;
}

int mulRec(int num) 
{
    if (num == 1) {
        return 1;
    } else {
        return num * mulRec(num - 1);
    }
}
