// Console.Write("Enter first number: ");
// string? firstLine = Console.ReadLine();
// Console.Write("Enter second number: ");
// string? secondLine = Console.ReadLine();
// int first = int.Parse(firstLine);
// int second = int.Parse(secondLine);
//
// bool fSecond = Math.Sqrt(second) == first;
// bool sFirst = Math.Sqrt(first) == second;
//
// if (fSecond == true)
// {
//    Console.WriteLine("второе квадрат первого"); 
// }
// else
// {
//     if (sFirst == true)
//     {
//         Console.WriteLine("первое квадрат второго");
//         
//     }
//     else
//     {
//         Console.WriteLine("ни одно не квадрат другого");
//     }
// }

// Задача №16
// Напишите программу, которая принимает на вход два числа и проверяет,
// является ли одно число квадратом другого.

Console.Clear();

Console.WriteLine("Введите первое число:");
string? inputFirst = Console.ReadLine();
Console.WriteLine("Введите второе число:");
string? inputSecond = Console.ReadLine();

if ((inputFirst != null) && (inputSecond != null))
{
    int inputNumberFirst = int.Parse(inputFirst);
    int inputNumberSecond = int.Parse(inputSecond);
    int a = inputNumberFirst * inputNumberFirst;
    int b = inputNumberSecond * inputNumberSecond;
    if ((a == inputNumberSecond) || (b == inputNumberFirst))
    {
        Console.WriteLine("Да!");
    }
    else
    {
        Console.WriteLine("Нет!");
    }

}
