// метод для заполнения двумерного массива
double[,] FillTwoDimArray(int countRow, int countColumn)
{
    double[,] inputArray = new double[countRow,countColumn];

    System.Random numberSyntezator = new System.Random();

    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            inputArray[i, j] = Math.Round(numberSyntezator.NextDouble(), 4);
            
        }
    }

    return inputArray;
}

// метод для окрашивания элементов массива
void PrintColorTwoDimArray(double[,] inputArray)
{
    ConsoleColor[] col = new ConsoleColor[]
    {
        ConsoleColor.Black, ConsoleColor.Blue, ConsoleColor.Cyan,
        ConsoleColor.Gray, ConsoleColor.Green, ConsoleColor.Magenta,
        ConsoleColor.Red, ConsoleColor.White, ConsoleColor.Yellow,
        ConsoleColor.DarkBlue, ConsoleColor.DarkCyan, ConsoleColor.DarkGray,
        ConsoleColor.DarkGreen, ConsoleColor.DarkMagenta, ConsoleColor.DarkRed,
        ConsoleColor.DarkYellow
    };
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            PrintColorDecimalsByDigit(inputArray[i,j]);
        }
        Console.WriteLine();
    }
}

// метод для окрашивания каждого символа дробной части (после запятой) в разный цвет с выводом на печать
void PrintColorDecimalsByDigit(double num)
{
    string[] numString = num.ToString().Split(",");
    char[] a = numString[1].ToString().ToCharArray();
    ConsoleColor[] col = new ConsoleColor[]
    {
        ConsoleColor.Black, ConsoleColor.Blue, ConsoleColor.Cyan,
        ConsoleColor.Gray, ConsoleColor.Green, ConsoleColor.Magenta,
        ConsoleColor.Red, ConsoleColor.White, ConsoleColor.Yellow,
        ConsoleColor.DarkBlue, ConsoleColor.DarkCyan, ConsoleColor.DarkGray,
        ConsoleColor.DarkGreen, ConsoleColor.DarkMagenta, ConsoleColor.DarkRed,
        ConsoleColor.DarkYellow
    };
    
    Console.Write(numString[0] + ",");

    // здесь перебираем полученный массив значений из дробной части
    for (int i = 0; i < a.Length; i++)
    {
        Console.ForegroundColor = col[new System.Random().Next(0,16)];
        Console.Write(a[i]);
        Console.ResetColor();
    }

    // здесь дозаполняем нулями, если число после округления имеет менее 4 цифр после запятой
    for (int i = 0; i < 4 - a.Length; i++)
    {
        Console.ForegroundColor = col[new System.Random().Next(0,16)];
        Console.Write("0");
        Console.ResetColor();
    }
    Console.Write("\t");
}

Console.Clear();
// запрос данных от пользователя с проверкой на корректность
Console.WriteLine("Введите кол-во строк: ");
string inputRow = Console.ReadLine();
if (Int32.TryParse(inputRow, out var arrCountRow) == true && arrCountRow > 0)                     //проверяем, что введено положительное число для строк
{
    Console.WriteLine("Введите кол-во столбцов: ");
    string inputCol = Console.ReadLine();
    if (Int32.TryParse(inputCol, out var arrCountCol) == true && arrCountCol > 0)                 //проверяем, что введено положительное число для столбцов
    {
        Console.Clear();
        PrintColorTwoDimArray(FillTwoDimArray(arrCountRow, arrCountCol));
    }
    else
    {
        Console.WriteLine("Некорректный ввод.");
    }
}
else
{
    Console.WriteLine("Некорректный ввод.");
}