// метод для заполнения массива
int[] FillArray(int[] arrData)
{
    int arrayLength = arrData[0];
    int arrayDown = arrData[1];
    int arrayUp = arrData[2];
    int[] inputArray = new int[arrayLength];
    int i = 0;
    System.Random numberSyntezator = new System.Random();
    while (i < inputArray.Length)
    {
        inputArray[i] = numberSyntezator.Next(arrayDown,arrayUp);
        i++;
    }

    return inputArray;
}

//метод для печати массива
void PrintArray(int[] inputArray)
{
    for (int i = 0; i < inputArray.Length - 1; i++)
    {
        Console.Write(inputArray[i] + ", ");
    }
    Console.WriteLine(inputArray[inputArray.Length - 1]);
}

// метод для проверки введенных пользователем значений
bool checkInt(string str, int number)
{
    bool resultCheck = false;
    switch (number)
    {
        case 1:
            if (Int32.TryParse(str, out var num1) == true)
            {
                if (num1 > 0)
                {
                    resultCheck = true;
                }
            }
            break;
        case 2:
            resultCheck = Int32.TryParse(str, out var num2);
            break;
    }

    return resultCheck;
}

// метод для запросу у пользователя данных для создаваемого массива
int[] arrayData()
{
    int arrayLength = 0;
    int arrayDown = 0;
    int arrayUp = 0;
    int[] arrData = new int[3];
    
    Console.WriteLine("Введите длину массива: ");
    string? input = Console.ReadLine();
    if (checkInt(input, 1) == true)
    {
        arrayLength = int.Parse(input);
    }
    else
    {
        Console.WriteLine("Вы ввели некорректные данные");
    }
    Console.WriteLine("Введите нижнюю границу: ");
    input = Console.ReadLine();
    if (checkInt(input, 2) == true)
    {
        arrayDown = int.Parse(input);
    }
    else
    {
        Console.WriteLine("Вы ввели некорректные данные");
    }
    Console.WriteLine("Введите верхнюю границу: ");
    input = Console.ReadLine();
    if (checkInt(input, 2) == true)
    {
        arrayUp = int.Parse(input);
    }
    else
    {
        Console.WriteLine("Вы ввели некорректные данные");
    }

    arrData[0] = arrayLength;
    arrData[1] = arrayDown;
    arrData[2] = arrayUp + 1;

    return arrData;
}

// метод для выбора рандомных имен
string NameArray(string inputLine)
{
    string[] NameArr = inputLine.Replace(" ", string.Empty).Split(new char[]{','}, StringSplitOptions.RemoveEmptyEntries);
    string rndName = NameArr[new System.Random().Next(0, NameArr.Length)];
    return rndName;
}

PrintArray(FillArray(arrayData()));
Console.WriteLine();
Console.Write("Введите имена через запятую:");
string? inputLine = Console.ReadLine();
Console.Write($"Случайное имя: {NameArray(inputLine)}");