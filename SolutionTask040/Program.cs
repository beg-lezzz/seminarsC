int sideA = 0;
int sideB = 0;
int sideC = 0;

void ReadSides()
{
    Console.Write("Введите число 1: ");
    sideA = int.Parse(Console.ReadLine() ?? "");
    Console.Write("Введите число 2: ");
    sideB = int.Parse(Console.ReadLine() ?? "");
    Console.Write("Введите число 3: ");
    sideC = int.Parse(Console.ReadLine() ?? "");
}

bool TestTriangle(int sideA, int sideB, int sideC)
{
    bool answer = (sideA + sideB > sideC) && 
                  (sideB + sideC > sideA) &&
                  (sideA + sideC) > sideB ? true : false;

    return answer;
}

void PrintAnswer(bool answer)
{
    if (answer)
    {
        Console.WriteLine("Да");
    }
    else
    {
        Console.WriteLine("Нет");
    }
}

ReadSides();
bool res = TestTriangle(sideA, sideB, sideC);
PrintAnswer(res);