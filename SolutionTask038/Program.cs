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

// метод для сортировки массива методом вставки
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

//метод для сортировки массива методом подсчета
void SortCountMethod()
{
    
}

Console.Clear();
Console.WriteLine("Введите количество элементов массива: ");
string input = Console.ReadLine();
if (Int32.TryParse(input, out var arrLength) == true)
{
    int[] inputArray = FillArray(arrLength);
    PrintArray(inputArray);
    PrintArray(SortInputMethod(inputArray));
}
else
{
    Console.WriteLine("Некорректный ввод.");
}