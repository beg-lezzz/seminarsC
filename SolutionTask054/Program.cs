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

// метод для создания одномерного массива из указанной строки двумерного массива
int[] CutStringFromArray(int[,] inputArray, int numString)
{
    int[] cutArray = new int[inputArray.GetLength(1)];
    for (int i = 0; i < inputArray.GetLength(1); i++)
    {
        cutArray[i] = inputArray[numString,i];
    }

    return cutArray;
}

// метод для перезаписи указанной строки двумерного массива из одномерного массива
int[,] PasteStringToArray(int[,] inputArray, int[] cutArray, int numString)
{
    for (int i = 0; i < inputArray.GetLength(1); i++)
    {
        inputArray[numString,i] = cutArray[i];
    }

    return inputArray;
}

// метод построчной сортировки двумерного массива
int[,] SortTwoDimArray(int[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        PasteStringToArray(inputArray, BubbleSortArray(CutStringFromArray(inputArray, i)),i);
    }
    
    return inputArray;
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

Console.Clear();
int arrCountRow = UserData("Введите число строк");
int arrCountCol = UserData("Введите число столбцов");

int[,] bufArray = FillTwoDimArray(arrCountRow, arrCountCol);

PrintTwoDimArray(bufArray);
Console.WriteLine();
PrintTwoDimArray(SortTwoDimArray(bufArray));
