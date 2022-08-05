int[] FillArray()
{
    int[] inputArray = new int[11];
    int i = 0;
    System.Random numberSyntezator = new System.Random();
    while (i < 11)
    {
        inputArray[i] = numberSyntezator.Next(-10,10);
        i++;
    }

    return inputArray;
}

void PrintArray(int[] inputArray)
{
    for (int i = 0; i < inputArray.Length - 1; i++)
    {
        Console.Write(inputArray[i] + ", ");
    }
    Console.WriteLine(inputArray[inputArray.Length - 1]);
}

int[] CalculateTask(int[] inputArray)
{
    int[] resultArray = new int[inputArray.Length / 2];
    int i = 0;

    while (i < resultArray.Length)
    {
        resultArray[i] = inputArray[i] * inputArray[inputArray.Length - i - 1];
        i++;
    }
    return resultArray;
}

int[] bufferArray = FillArray();
PrintArray(bufferArray);
Console.WriteLine();
int[] resultArray = CalculateTask(bufferArray);
PrintArray(resultArray);