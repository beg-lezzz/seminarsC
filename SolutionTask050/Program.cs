// метод для генерации чисел Фибоначчи
int Fibonacci(int n)
{
    if (n == 0) return 0;
    if (n == 1 || n == 2) return 1;
    else return Fibonacci(n - 1) + Fibonacci(n - 2);
}

// метод для заполнения двумерного массива числами Фибоначчи
int[,] FillTwoDimArray(int countRow, int countColumn)
{
    int[,] inputArray = new int[countRow,countColumn];
    int count = 0;

    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            inputArray[i, j] = Fibonacci(count);
            count++;
        }
    }

    return inputArray;
}

void PrintTwoDimArray(int[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write(inputArray[i,j] + "\t");
        }
        Console.WriteLine();
    }
}

// метод для окрашивания найденного элемента массива
void PrintColorTwoDimArray(int[,] inputArray, string coords)
{
    int searchI = int.Parse(coords.Split(",")[0]);
    int searchJ = int.Parse(coords.Split(",")[1]);
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            if (i == searchI && j == searchJ)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write(inputArray[i,j] + "\t");
                Console.ResetColor();
            }
            else
            {
                Console.Write(inputArray[i,j] + "\t");
            }
        }
        Console.WriteLine();
    }
}

// метод для поиска значения в массиве
string SearchNumber(ref int[,] bufArray, int searchNumber)
{
    string coords = String.Empty;
    for (int i = 0; i < bufArray.GetLength(0); i++)
    {
        for (int j = 0; j < bufArray.GetLength(1); j++)
        {
            if (bufArray[i, j] == searchNumber)
            {
                coords = $"{i},{j}";
                break;
            }
        }
    }
    return coords;
}

// запрос данных от пользователя с проверкой на корректность
string InputData()
{
    string numRowsAndCols = String.Empty;
    Console.WriteLine("Введите кол-во строк: ");
    string inputRow = Console.ReadLine();
    if (Int32.TryParse(inputRow, out var arrCountRow) == true && arrCountRow > 0)                     //проверяем, что введено положительное число для строк
    {
        Console.WriteLine("Введите кол-во столбцов: ");
        string inputCol = Console.ReadLine();
        if (Int32.TryParse(inputCol, out var arrCountCol) == true && arrCountCol > 0)                 //проверяем, что введено положительное число для столбцов
        {
            numRowsAndCols = $"{arrCountRow},{arrCountCol}";
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Некорректный ввод.");
            Console.ResetColor();
        }
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("Некорректный ввод.");
        Console.ResetColor();
    }

    return numRowsAndCols;
}

void InputSearch(int[,] bufArray)
{
    Console.WriteLine("Введите искомое число: ");
    string inputSearchNum = Console.ReadLine();
    if (Int32.TryParse(inputSearchNum, out var searchNum) == true)                     //проверяем, что введено число для поиска
    {
        string res = SearchNumber(ref bufArray, searchNum);
        if (res != string.Empty)
        {
            Console.WriteLine();
            Console.WriteLine("Искомое число найдено и выделено зеленым цветом: ");
            PrintColorTwoDimArray(bufArray, res);
        }
        else
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Искомое число не найдено");
            Console.ResetColor();
        }
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("Некорректный ввод.");
        Console.ResetColor();
    }
}

Console.Clear();
string arrDimensions = InputData();
int.TryParse(arrDimensions.Split(",")[0], out int arrCountRow);
int.TryParse(arrDimensions.Split(",")[1], out int arrCountCol);

int[,] bufArray = FillTwoDimArray(arrCountRow, arrCountCol);
Console.WriteLine();
PrintTwoDimArray(bufArray);
Console.WriteLine();
InputSearch(bufArray);

