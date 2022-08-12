// метод для заполнения массива
int[] FillArray(int arrLength)
{
    int[] inputArray = new int[arrLength];
    int i = 0;
    System.Random numberSyntezator = new System.Random();
    while (i < arrLength)
    {
        inputArray[i] = numberSyntezator.Next(-100,101);
        i++;
    }

    return inputArray;
}

// метод печати массива
void PrintArray(int[] inputArray)
{
    for (int i = 0; i < inputArray.Length - 1; i++)
    {
        Console.Write(inputArray[i] + ", ");
    }
    Console.WriteLine(inputArray[inputArray.Length - 1]);
}

// метод меняет местами два элемента массива
void SwapArray(int[] inputArray, int i, int j)
{
    int tmp = inputArray[i];
    inputArray[i] = inputArray[j];
    inputArray[j] = tmp;
}

// метод для сортировки массива вставкой
int[] SortInputMethod(int[] inputArray)
{
    int bufElement;
    int lastPosition;
    for (int i = 1; i < inputArray.Length; i++)
    {
        bufElement = inputArray[i];
        lastPosition = i;
        while (lastPosition > 0 && inputArray[lastPosition -1] > bufElement)
        {
            SwapArray(inputArray, lastPosition, lastPosition - 1);
            lastPosition-=1;
        }

        inputArray[lastPosition] = bufElement;
    }

    return inputArray;
}

//метод для сортировки массива методом подсчетом
int[] SortCountMethod(int[] inputArray)
{
    int length = Math.Abs(inputArray.Max()) + Math.Abs(inputArray.Min()) + 1;
    int[] sortedArray = new int[inputArray.Length];
    int[] indexArray = new int[length];
    
    int countElementsOfIndexArray = 0;
    for (int i = inputArray.Min(); i <= inputArray.Max(); i++)
    {
        indexArray[countElementsOfIndexArray] = i;
        countElementsOfIndexArray++;
    }
    
    int countElementsOfSortedArray = 0;
    for (int i = 0; i < indexArray.Length; i++)
    {
        int tmp = 0;
        int countMatchedElements = 0;
        for (int j = 0; j < inputArray.Length; j++)
        {
            if (indexArray[i] == inputArray[j])
            {
                tmp = inputArray[j];
                countMatchedElements++;
            }
        }

        for (int j = 0; j < countMatchedElements; j++)
        {
            sortedArray[countElementsOfSortedArray] = tmp;
            countElementsOfSortedArray++;
        }
    }

    return sortedArray;
}

// метод нахождения разницы первого и последнего элемента
int NumbersDif(int[] inputArray)
{
    int dif = inputArray[0] - inputArray[inputArray.Length - 1];
    
    return dif;
}

Console.Clear();
Console.WriteLine("Введите количество элементов массива: ");
string input = Console.ReadLine();
if (Int32.TryParse(input, out var arrLength) == true)
{
    int[] inputArray = FillArray(arrLength);
    PrintArray(inputArray);
    Console.WriteLine();
    Console.WriteLine("Отсортированный массив методом вставки: ");
    PrintArray(SortInputMethod(inputArray));
    Console.WriteLine($"Разница между первым и последним элементом = " +
                      $"{NumbersDif(SortInputMethod(inputArray))}");
    Console.WriteLine();
    Console.WriteLine("Отсортированный массив методом подсчета: ");
    PrintArray(SortCountMethod(inputArray));
    Console.WriteLine($"Разница между первым и последним элементом = " +
                      $"{NumbersDif(SortCountMethod(inputArray))}");
}
else
{
    Console.WriteLine("Некорректный ввод.");
}