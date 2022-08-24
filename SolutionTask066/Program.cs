// метод для запроса данных у пользователя
int UserData(string inputString)
{
    Console.Write(inputString + ": ");
    string numString = Console.ReadLine();
    if (Int32.TryParse(numString, out int num) == true && num > 0)                                       //проверяем, что введено положительное число для строк
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

// рекурсивный метод для суммы всех натуральных чисел от M до N
int NaturalNumberPrinter(int m, int n)
{
    //Console.Write(m + " ");
    if (m == n) return m;
    return m + NaturalNumberPrinter(++m, n);
}

Console.Clear();
int inputNumM = UserData("Введите первое число");
int inputNumN = UserData("Введите второе число");

// проверка, чтобы вывод был от меньшего числа к большему
if (inputNumM < inputNumN)
{
    Console.WriteLine($"Сумма чисел от {inputNumM} до {inputNumN} =" +
                      $" {NaturalNumberPrinter(inputNumM, inputNumN)}");
}
else
{
    Console.WriteLine($"Сумма чисел от {inputNumN} до {inputNumM} =" +
                      $" {NaturalNumberPrinter(inputNumN, inputNumM)}");
}