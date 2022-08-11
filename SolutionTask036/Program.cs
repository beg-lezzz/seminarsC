// метод для заполнения массива
int[] FillArray(int arrLength)
{
    int[] inputArray = new int[arrLength];
    int i = 0;
    System.Random numberSyntezator = new System.Random();
    while (i < arrLength)
    {
        inputArray[i] = numberSyntezator.Next(-10,11);
        i++;
    }

    return inputArray;
}

// метод печати массива
void PrintArray(int[] inputArray)
{
    for (int i = 0; i < inputArray.Length - 1; i++)
    {
        Console.Write(inputArray[i] + ", ");
    }
    Console.WriteLine(inputArray[inputArray.Length - 1]);
}

//метод суммирования элементов массива на нечетных позициях
int Calculate(int[] inputArray)
{
    int sum = 0;
    for (int i = 1; i < inputArray.Length; i+=2)
    {
        sum += inputArray[i];
    }

    return sum;
}

//метод для поиска пар элементов
void FindAndPrintPares(int[] inputArray)
{
    int pareCount = 0;
    for (int i = 0; i < inputArray.Length - 1; i++)
    {
        if (inputArray[i] == inputArray[i + 1])
        {
            pareCount++;
            Console.WriteLine($"{pareCount} пара элементов = {inputArray[i]}" +
                              $" на позициях {i} и {i + 1}");
        }
    }
    Console.WriteLine();
    Console.WriteLine($"Кол-во пар элементов = {pareCount}");
}

Console.Clear();
Console.WriteLine("Введите количество элементов массива: ");
string input = Console.ReadLine();
if (Int32.TryParse(input, out var arrLength) == true)
{
    int[] inputArray = new int[arrLength];
    inputArray = FillArray(arrLength);
    Console.WriteLine();
    Console.WriteLine("Исходный массив: ");
    PrintArray(inputArray);
    Console.WriteLine();
    Console.WriteLine($"Сумма элементов на нечетных позициях = " +
                      $"{Calculate(inputArray)}");
    Console.WriteLine();
    FindAndPrintPares(inputArray);
}
else
{
    Console.WriteLine("Некорректный ввод.");
}
