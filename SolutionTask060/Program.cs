// метод для заполнения трехмерного массива
int[,,] FillThreeDimArray(int firstDim, int secondDim, int thirdDim, int[] uniqNumsArray)
{
    int[,,] inputArray = new int[firstDim,secondDim, thirdDim];
    int count = 0;

    System.Random numberSyntezator = new System.Random();

    for (int i = 0; i < firstDim; i++)
    {
        for (int j = 0; j < secondDim; j++)
        {
            for (int k = 0; k < thirdDim; k++)
            {
                inputArray[i, j, k] = uniqNumsArray[count];
                count++;
            }
        }
    }

    return inputArray;
}

// метод для создания списка уникальных двузначных чисел
int[] CreateUniqNums(int firstDim, int secondDim, int thirdDim)
{
    int[] uniqNumsArray = new int[firstDim * secondDim * thirdDim];

    for (int i = 0; i < uniqNumsArray.Length; i++)
    {
        System.Random numberSyntezator = new System.Random();
        int buf = numberSyntezator.Next(10, 100);
        while (System.Array.IndexOf(uniqNumsArray, buf) >= 0)
        {
            buf = numberSyntezator.Next(10, 100);
        }
        
        uniqNumsArray[i] = buf;
    }

    return uniqNumsArray;
}

// метод для печати трехмерного массива
void PrintThreeDimArray(int[,,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            for (int k = 0; k < inputArray.GetLength(2); k++)
            {
                Console.Write($"{inputArray[i,j,k]} ({i},{j},{k}) \t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    Console.WriteLine();
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
int firstDim = UserData("Введите первую размерность");
int secondDim = UserData("Введите вторую размерность");
int thirdDim = UserData("Введите третью размерность");

if (firstDim * secondDim * thirdDim > 99)
{
    Console.WriteLine("Невозможно заполнить массив неповторяющимися двузначными числами!");
}
else
{
    Console.WriteLine();
    PrintThreeDimArray(FillThreeDimArray(firstDim, secondDim, thirdDim, CreateUniqNums(firstDim, secondDim, thirdDim)));
}