Console.Clear();
int numberN = ReadData("Задайте число M: ");
int numberM = ReadData("Задайте число N: ");
int sum = 0;

// if (numberM < numberN)
// {
//     Console.WriteLine(PowNumber(numberM, numberN));
// }
// else
// {
//     Console.WriteLine(PowNumber(numberN, numberM));
// }

Console.WriteLine(PowNumber(numberM, numberN));

int ReadData(string line)
{
    Console.WriteLine(line);
    return int.Parse(Console.ReadLine() ?? "");
}

int PowNumber(int m, int n)
{
    if (n == 1) return m;
    return m * PowNumber(m, --n);
}