// Console.WriteLine("Введите число: ");
// string? inputLineN = Console.ReadLine();
//
// if (inputLineN != null)
// {
//     int number = int.Parse(inputLineN);
//     string? lineN = "";
//     string? lineNN = string.Empty;
//     int counter = 1;
//
//     while (counter < number + 1)
//     {
//         lineN = lineN + counter + " ";
//         lineNN = lineNN + counter * counter + " ";
//
//         counter++;
//     }
//     
//     Console.WriteLine(lineN);
//     Console.WriteLine(lineNN);
// }

// Вариант Кирилла

List<int> listGen(int number)
{
    List<int> numbers = new List<int>();
    for (int i = 1; i < number + 1; i++)
    {
        numbers.Add(i);
    }

    return numbers;
}

string? inputLine = Console.ReadLine();

if (inputLine != null)
{
    int inputNumber = int.Parse(inputLine);
    List<int> nums = listGen(inputNumber);
    foreach (var i in nums)
    {
        Console.Write(i);
        Console.Write(" ");
    }
    Console.WriteLine();

    foreach (var i in nums)
    {
        Console.Write(Math.Pow(i,2));
        Console.Write(" ");
    }
}