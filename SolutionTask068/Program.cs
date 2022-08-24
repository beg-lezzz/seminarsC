// метод для запроса данных у пользователя
int UserData(string inputString)
{
    Console.Write(inputString + ": ");
    string numString = Console.ReadLine();
    if (Int32.TryParse(numString, out int num) == true && num >= 0)                                       //проверяем, что введено положительное число для строк
    {
        return num;
    }
    else
    {
        Console.WriteLine("Ошибка ввода");
        System.Environment.Exit(1);
        return 0;
    }
}

// рекурсивный метод для вычисления функции Аккермана пары чисел
int AckermanFunc(int m, int n)
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return AckermanFunc(m - 1, 1);
    if (m > 0 && n > 0) return AckermanFunc(m - 1, AckermanFunc(m, n -1));
    return AckermanFunc(m, n);
}

Console.Clear();
int inputNumM = UserData("Введите первое число");
int inputNumN = UserData("Введите второе число");

Console.WriteLine($"Функция Аккермана пары чисел ({inputNumM};{inputNumN}) =" +
                       $" {AckermanFunc(inputNumM, inputNumN)}");