Console.Clear();
int numberN = ReadData("Задайте число M: ");
int numberM = ReadData("Задайте число N: ");
int sum = 0;

if (numberM < numberN)
{
    Console.WriteLine(NaturalNumberPrinter(numberM, numberN));
}
else
{
    Console.WriteLine(NaturalNumberPrinter(numberN, numberM));
}

int ReadData(string line)
{
    Console.WriteLine(line);
    return int.Parse(Console.ReadLine());
}

int NaturalNumberPrinter(int m, int n)
{
    Console.Write(m + " ");
    if (m == n) return m;
    return m + NaturalNumberPrinter(++m, n);
    //NaturalNumberPrinter(m + 1, n);
}