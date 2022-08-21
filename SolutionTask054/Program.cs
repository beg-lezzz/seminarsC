// сортировка методом пузырька
int[] BubbleSortArray(int[] inputArray)
{
    int tmp;
    int k = inputArray.Length - 1;

    for (int i = 0; i < inputArray.Length; i++)
    {
        for (int j = 0; j < k; j++)
        {
            if (inputArray[j] > inputArray[j + 1])
            {
                tmp = inputArray[j];
                inputArray[j] = inputArray[j + 1];
                inputArray[j + 1] = tmp;
            }
        }
        k--;
    }
    return inputArray;
}

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

// метод построчной сортировки двумерного массива
int[,] SortTwoDimArray(int[,] inputArray)
{
    int[] bufArray = new int[inputArray.GetLength(0)];

    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            bufArray[j] = inputArray[i,j];
        }

        bufArray = BubbleSortArray(bufArray);

        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            inputArray[i,j] = bufArray[j];
        }
    }
    
    return inputArray;
}

Console.Clear();
string arrDimensions = InputData();
int.TryParse(arrDimensions.Split(",")[0], out int arrCountRow);
int.TryParse(arrDimensions.Split(",")[1], out int arrCountCol);

int[,] rndArray = FillTwoDimArray(arrCountRow, arrCountCol);

PrintTwoDimArray(rndArray);
Console.WriteLine();
PrintTwoDimArray(SortTwoDimArray(rndArray));
