Console.WriteLine("Введите первое число:");
string? inputlineA = Console.ReadLine();
Console.WriteLine("Введите второе число:");
string? inputlineB = Console.ReadLine();



if (inputlineA != null && inputlineB != null)
{
    int inputnumberA = int.Parse(inputlineA);
    int inputnumberB = int.Parse(inputlineB);

//    if ((int)Math.Pow(inputnumberB,2) == inputnumberA)
    if ((int)Math.Sqrt(inputnumberA) == inputnumberB)
    {
        Console.WriteLine("Да");
    }
    else
    {
        Console.WriteLine("Нет");
    }
}