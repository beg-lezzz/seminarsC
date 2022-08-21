// метод для заполнения двумерного массива
int[,] FillTwoDimArray(int countRow, int countColumn)
{
    int[,] inputArray = new int[countRow,countColumn];

    System.Random numberSyntezator = new System.Random();

    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            inputArray[i, j] = numberSyntezator.Next(0, 10);
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

// метод для вычисления произведения двух матриц
int[,] SearchMultipleOfArrays(int[,] firstArray, int[,] secondArray)
{
    int[,] multiplArray = new int[firstArray.GetLongLength(0), firstArray.GetLongLength(1)];

    for (int i = 0; i < firstArray.GetLongLength(0); i++)
    {
        for (int j = 0; j < firstArray.GetLongLength(1); j++)
        {
            multiplArray[i, j] = firstArray[i, j] * secondArray[i, j];
        }
    }
    
    return multiplArray;
}

Console.Clear();
int arrCountRow = UserData("Введите число строк");
int arrCountCol = UserData("Введите число столбцов");

int[,] firstArray = FillTwoDimArray(arrCountRow, arrCountCol);
int[,] secondArray = FillTwoDimArray(arrCountRow, arrCountCol);

Console.WriteLine();
Console.WriteLine("Первый массив:");
PrintTwoDimArray(firstArray);
Console.WriteLine();
Console.WriteLine("Второй массив:");
PrintTwoDimArray(secondArray);
Console.WriteLine();
Console.WriteLine("Произведение массивов:");
PrintTwoDimArray(SearchMultipleOfArrays(firstArray, secondArray));