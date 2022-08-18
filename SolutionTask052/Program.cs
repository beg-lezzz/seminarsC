// метод для заполнения двумерного массива
int[,] FillTwoDimArray(int countRow, int countColumn)
{
    int[,] inputArray = new int[countRow,countColumn];

    System.Random numberSyntezator = new System.Random();

    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            inputArray[i, j] = numberSyntezator.Next(10, 100);
        }
    }

    return inputArray;
}

// метод для печати двумерного массива
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

// метод подсчета ср. арифметического по диагоналям справа налево и их закраска разными цветами
void PrintColorDiagonalesRightToLeft(int[,] inputArray)
{
    System.Random numberSyntezator = new System.Random();
    int count = 0;
    double sumRight = 0;
    double sumUp = 0;
    int countElems = 0;
    ConsoleColor[] col = new ConsoleColor[]
    {
        ConsoleColor.Black, ConsoleColor.Blue, ConsoleColor.Cyan,
        ConsoleColor.Gray, ConsoleColor.Green, ConsoleColor.Magenta,
        ConsoleColor.Red, ConsoleColor.White, ConsoleColor.Yellow,
        ConsoleColor.DarkBlue, ConsoleColor.DarkCyan, ConsoleColor.DarkGray,
        ConsoleColor.DarkGreen, ConsoleColor.DarkMagenta, ConsoleColor.DarkRed,
        ConsoleColor.DarkYellow
    };
    ConsoleColor[] colorDigs = new ConsoleColor[inputArray.GetLength(0) + inputArray.GetLength(1)];
    for (int i = 0; i < (inputArray.GetLength(0) + inputArray.GetLength(1)); i++)
    {
        colorDigs[i]  = col[numberSyntezator.Next(0, 16)];
    }

    // считаем ср. арифметическое по диагоналям, начинающимся в первой строке исходного массива и выводим первой строкой
    for (int j = 0; j < inputArray.GetLength(1); j++)
    {
        for (int i = 0; i < inputArray.GetLongLength(0); i++)
        {
            if ((j - i) >=0)
            {
                sumUp += inputArray[i,j-i];
                countElems++;
            }
        }
        Console.ForegroundColor = colorDigs[j];
        Console.Write(Math.Round(sumUp/countElems, 1) + "\t");
        Console.ResetColor();
        sumUp = 0;
        countElems = 0;
    }
    
    Console.WriteLine();
    
    // разделитель
    for (int i = 0; i < inputArray.GetLength(1)*8; i++)
    {
        Console.Write("-");
    }
    Console.WriteLine();

    // считаем ср. арифметическое по диагоналям, начинающимся в первой строке исходного массива и выводим последним столбцом
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int k = inputArray.GetLength(1) - 1; k >= 0; k--)
        {
            if ((i+count) < inputArray.GetLength(0))
            {
                sumRight += inputArray[i + count, k];
                countElems++;
                count++;
            }
        }

        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.ForegroundColor = colorDigs[i+j];
            Console.Write(inputArray[i,j] + "\t");
            Console.ResetColor();
        }
        
        Console.ForegroundColor = colorDigs[i + inputArray.GetLength(1)-1];
        Console.Write(" | {0, " + -4 + "}", Math.Round(sumRight/countElems, 1));
        
        Console.WriteLine();
        countElems = 0;
        count = 0;
        sumRight = 0;
    }
}

// метод подсчета ср. арифметического по диагоналям слева направо и их закраска разными цветами
void PrintColorDiagonalesLeftToRight(int[,] inputArray)
{
    // создаем рандомайзер для цветов
    System.Random numberSyntezator = new System.Random();
    // создаем коллекцию цветов
    ConsoleColor[] col = new ConsoleColor[]
    {
        ConsoleColor.Black, ConsoleColor.Blue, ConsoleColor.Cyan,
        ConsoleColor.Gray, ConsoleColor.Green, ConsoleColor.Magenta,
        ConsoleColor.Red, ConsoleColor.White, ConsoleColor.Yellow,
        ConsoleColor.DarkBlue, ConsoleColor.DarkCyan, ConsoleColor.DarkGray,
        ConsoleColor.DarkGreen, ConsoleColor.DarkMagenta, ConsoleColor.DarkRed,
        ConsoleColor.DarkYellow
    };
    int count = 0;
    double sumLeft = 0;
    double sumUp = 0;
    int countElems = 0;
    // создаем и заполняем через рандомайзер массив цветов по длине == кол-во строк + кол-во столбцов исходного массива
    ConsoleColor[] colorDigs = new ConsoleColor[inputArray.GetLength(0) + inputArray.GetLength(1)];
    for (int i = 0; i < (inputArray.GetLength(0) + inputArray.GetLength(1)); i++)
    {
        colorDigs[i]  = col[numberSyntezator.Next(0, 16)];
    }

    // разделитель
    Console.Write(" {0, " + -4 + "} | ", " ");

    // считаем ср. арифметическое по диагоналям, начинающимся в первой строке исходного массива и выводим первой строкой
    for (int j = 0; j < inputArray.GetLength(1); j++)
    {
        for (int i = 0; i < inputArray.GetLongLength(0); i++)
        {
            if ((i + j) < inputArray.GetLength(1))
            {
                sumUp += inputArray[i,i+j];
                countElems++;
            }
        }
        Console.ForegroundColor = colorDigs[j + inputArray.GetLength(0)];
        Console.Write(Math.Round(sumUp/countElems, 1) + "\t");
        Console.ResetColor();
        sumUp = 0;
        countElems = 0;
    }
    
    // разделители
    Console.WriteLine();
    for (int i = 0; i < inputArray.GetLength(1)*8; i++)
    {
        Console.Write("-");
    }
    Console.WriteLine();
    
    // считаем ср. арифметическое по диагоналям, начинающимся в первом столбце исходного массива и выводим первым столбцом
    countElems = 0;
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int k = 0; k < inputArray.GetLength(1); k++)
        {
            if ((i + k) < inputArray.GetLength(0))
            {
                sumLeft += inputArray[i+k, k];
                countElems++;
            }
        }
        
        Console.ForegroundColor = colorDigs[inputArray.GetLength(0)-count];
        Console.Write(" {0, " + -4 + "} | ", Math.Round(sumLeft/countElems,1));
        
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.ForegroundColor = colorDigs[j + inputArray.GetLength(0)-count];
            Console.Write(inputArray[i,j] + "\t");
            Console.ResetColor();
        }
    
        Console.WriteLine();
        count++;
        sumLeft = 0;
        countElems = 0;
    }
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

Console.Clear();
string arrDimensions = InputData();
Console.WriteLine();
int.TryParse(arrDimensions.Split(",")[0], out int arrCountRow);
int.TryParse(arrDimensions.Split(",")[1], out int arrCountCol);

int[,] bufArray = FillTwoDimArray(arrCountRow, arrCountCol);
Console.WriteLine("Исходный массив:");
PrintTwoDimArray(bufArray);
Console.WriteLine();
Console.WriteLine("Ср. арифметическое по диагонялям слева направо:");
PrintColorDiagonalesLeftToRight(bufArray);

Console.WriteLine();
Console.WriteLine("Ср. арифметическое по диагонялям справа налево:");
PrintColorDiagonalesRightToLeft(bufArray);