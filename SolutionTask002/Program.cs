Console.Write("Введите первое число: ");
string? inputlineA = Console.ReadLine();
Console.Write("Введите второе число: ");
string? inputlineB = Console.ReadLine();

if (inputlineA != null && inputlineB != null)
{
    int inputNumberA = int.Parse(inputlineA);
    int inputNumberB = int.Parse(inputlineB);
    int max = inputNumberA;
        
    if (max == inputNumberB)
    {
        Console.WriteLine("Числа равны");
    }
    else
    {
        if (max < inputNumberB)
        {
            max = inputNumberB;
        }
        
        Console.Write("max = " + max);
    }
}