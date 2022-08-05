int[] FillArray()
{
    int[] inputArray = new int[12];
    int i = 0;
    System.Random numberSyntezator = new System.Random();
    while (i < 12)
    {
        inputArray[i] = numberSyntezator.Next(-9, 10);
        i++;
    }

    return inputArray;
}

void PrintArray(int[] outArray)
{
    for (int i = 0; i < outArray.Length - 1; i++)
    {
        Console.Write(outArray[i] + ", ");
    }
    Console.WriteLine(outArray[outArray.Length - 1]);
}

bool CalculateTask(int[] inputArray, int searchNumber)
{
    bool resultSearch = false;
    int i = 0;
    while (i < 12)
    {
        if (inputArray[i] == searchNumber)
        {
            resultSearch = true;
            break;
        }
        i++;
    }

    return resultSearch;
}

int[] bufferArray = FillArray();
PrintArray(bufferArray);

Console.Write("Введите число для поиска: ");
int searchNumber = int.Parse(Console.ReadLine());
Console.WriteLine(CalculateTask(bufferArray, searchNumber));


