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

// метод для суммирования элементов указанной строки двумерного массива
int SumStringFromArray(int[,] inputArray, int numString)
{
    int sumString = 0;
    for (int i = 0; i < inputArray.GetLength(1); i++)
    {
        sumString+= inputArray[numString,i];
    }

    //Console.WriteLine(sumString);
    return sumString;
}

// метод для поиска индекса строки с наименьшей суммой элементов
int SearchNumStringMinSum(int[,] inputArray)
{
    int NumString = 0;
    int sumString = SumStringFromArray(inputArray, 0);
    
    for (int i = 1; i < inputArray.GetLength(0); i++)
    {
        int sumStringNext = SumStringFromArray(inputArray, i);
        if (sumStringNext < sumString)
        {
            NumString = i;
            sumString = sumStringNext;
        }
    }
    
    return NumString + 1;
}

Console.Clear();
int arrCountRow = UserData("Введите число строк");
int arrCountCol = UserData("Введите число столбцов");

int[,] bufArray = FillTwoDimArray(arrCountRow, arrCountCol);

PrintTwoDimArray(bufArray);
Console.WriteLine();
Console.WriteLine(SearchNumStringMinSum(bufArray));