int positSum = 0;
int negatSum = 0;

int[] FillArray()
{
    int[] outArray = new int[12];
    int i = 0;
    System.Random numberSyntezator = new System.Random();
    while (i < 12)
    {
        outArray[i] = numberSyntezator.Next(-9, 10);
        i++;
    }

    return outArray;
}

void PrintArray(int[] outArray)
{
    for (int i = 0; i < outArray.Length - 1; i++)
    {
        Console.Write(outArray[i] + ", ");
    }
    Console.WriteLine(outArray[outArray.Length - 1]);
}

void CalculateTask(int[] outArray)
{
    int i = 0;
    while (i < 12)
    {
        if (outArray[i] > 0)
        {
            positSum += outArray[i];
        }
        else
        {
            negatSum += outArray[i];
        }

        i++;
    }
}

void PrintResult()
{
    Console.WriteLine(positSum);
    Console.WriteLine(negatSum);
}

void VariantNaive()
{
    int[] bufferArray = FillArray();
    PrintArray(bufferArray);
    CalculateTask(bufferArray);
    PrintResult();
}

VariantNaive();