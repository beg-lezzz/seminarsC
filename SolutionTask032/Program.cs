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

int[] CalculateTask(int[] inputArray)
{
    int[] outputArray = new int[12];
    int i = 0;
    while (i < 12)
    {
        outputArray[i] = inputArray[i] * -1;
        i++;
    }

    return outputArray;
}

int[] bufferArray = FillArray();
PrintArray(bufferArray);
int[] resultArray = CalculateTask(bufferArray);
PrintArray(resultArray);