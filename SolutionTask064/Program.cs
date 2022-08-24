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

// рекурсивный метод для вывода всех натуральных чисел от M до N
int NaturalNumberPrinter(int m, int n)
{
    if (m == n) return m;
    Console.Write(m + " ");
    return NaturalNumberPrinter(++m, n);
}

Console.Clear();
int inputNumM = UserData("Введите первое число");
int inputNumN = UserData("Введите второе число");

// проверка, чтобы вывод был от меньшего числа к большему
if (inputNumM < inputNumN)
{
    Console.WriteLine(NaturalNumberPrinter(inputNumM, inputNumN));
}
else
{
    Console.WriteLine(NaturalNumberPrinter(inputNumN, inputNumM));
}