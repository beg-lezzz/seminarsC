int[] FillArray()
{
    int[] inputArray = new int[123];
    int i = 0;
    System.Random numberSyntezator = new System.Random();
    while (i < 123)
    {
        inputArray[i] = numberSyntezator.Next(-1000,1000);
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

int CalculateTask(int[] inputArray, int downBorder, int upBorder)
{
    int resultCount = 0;
    int i = 0;
    while (i < inputArray.Length)
    {
        if (inputArray[i] >= downBorder && inputArray[i] <= upBorder)
        {
            resultCount++;
            Console.Write(inputArray[i] + " ");
        }
        i++;
    }

    return resultCount;
}

int[] bufferArray = FillArray();
PrintArray(bufferArray);
Console.WriteLine(CalculateTask(bufferArray, 10, 99));