// метод печати массива
void PrintArray(string[] inputArray)
{
    for (int i = 0; i < inputArray.Length - 1; i++)
    {
        Console.Write(inputArray[i] + ", ");
    }
    Console.WriteLine(inputArray[inputArray.Length - 1]);
}

// метод, заполняющий массив допустимых значений
string[] NumsArrayFill()
{
    string[] numsArray = new string[21];
    for (int i = 0; i < 10; i++)
    {
        numsArray[i] = $"D{i}";
    }
    for (int i = 10; i < 20; i++)
    {
        numsArray[i] = $"NumPad{i}";
    }
    numsArray[20] = "OemMinus";
    
    return numsArray;
}

// метод для проверки вводимых значений на принадлежность к числам и подсчет/сумирование чисел
void CountAndSum(int input, string[] buf)
{
    int countNums = 0;
    int sumNums = 0;
    ConsoleKey oldKey = new ConsoleKey();
    Console.WriteLine("Вводите числа: ");
    for (int i = 0; i < input; i++)
    {
        bool flagMinus = false;
        var key = Console.ReadKey(true);
        ConsoleKeyInfo keyUP = key;
        flagMinus = oldKey == ConsoleKey.OemMinus;
        if (buf.Contains(keyUP.Key.ToString()) && keyUP.Key != ConsoleKey.OemMinus && key.Modifiers != ConsoleModifiers.Shift) countNums++;
        if (buf.Contains(keyUP.Key.ToString()) && int.TryParse(key.KeyChar.ToString(), out int num) && num > 0 && flagMinus == false) sumNums += num;
        oldKey = key.Key;
        Console.WriteLine($"{keyUP.Key.ToString()} - {countNums} - {sumNums} - {oldKey} - {flagMinus}");
    }
    Console.WriteLine($"Количество введенных чисел = {countNums}");
    Console.WriteLine($"Сумма чисел > 0 = {sumNums}");
}

Console.Write("Введите число нажатий: ");
bool isNum = int.TryParse(Console.ReadLine(), out int input);

if (isNum)
{
    string[] buff = new string[21];
    buff = NumsArrayFill();
    CountAndSum(input,buff);
}
else
{
    Console.WriteLine("Ошибка ввода");
}