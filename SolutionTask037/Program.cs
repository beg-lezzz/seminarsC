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

int[] CalculateTask(int[] inputArray)
{
    int[] resultArray = new int[inputArray.Length / 2 + 1];
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
Console.WriteLine("------");
Console.WriteLine("------");
Console.WriteLine("------");
int[] resultArray = CalculateTask(bufferArray);
PrintArray(resultArray);