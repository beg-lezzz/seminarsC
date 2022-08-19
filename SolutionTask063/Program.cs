Console.Clear();

int ReadData()
{
    Console.WriteLine("Задайте число: ");
    return int.Parse(Console.ReadLine());
}

int NaturalNumberPrinter(int num)
{
    if (num == 2) return 1;
    else
    {
        num--;
        Console.WriteLine(num);
        Console.Write(NaturalNumberPrinter(num) + " ");
    }

    return num;
}

int inputData = ReadData();
NaturalNumberPrinter(inputData + 2);