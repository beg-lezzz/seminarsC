object[] FillArray()
{
    object[] inputArray = new object[11];
    int i = 0;
    System.Random numberSyntezator = new System.Random();
    while (i < 11)
    {
        inputArray[i] = numberSyntezator.Next(-10,10);
        i++;
    }

    return inputArray;
}

void PrintArray(object[] inputArray)
{
    for (int i = 0; i < inputArray.Length - 1; i++)
    {
        Console.Write(inputArray[i] + ", ");
    }
    Console.WriteLine(inputArray[inputArray.Length - 1]);
}

object[] CopyArrayStandartTool(object[] inputArray)
{
    object[] bufArray = new object[inputArray.Length];
    inputArray.CopyTo(bufArray,0);

    return bufArray;
}

object[] CopyArrayTool(object[] inputArray)
{
    object[] bufArray = new object[inputArray.Length];
    for (int i = 0; i < inputArray.Length; i++)
    {
        bufArray[i] = inputArray[i];
    }

    return bufArray;
}

object[] buf = FillArray();
PrintArray(buf);
PrintArray(CopyArrayStandartTool(buf));
PrintArray(CopyArrayTool(buf));