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

int[] ReverseSwapArray(int[] array){
    int length = array.Length;
    int buf;
    
    for (int i = 0; i < length/2; i++)
    {
        buf = array[i];
        array[i] = array[length - 1 - i];
        array[length - 1 - i] = buf;
    }
    return array;
}

int[] reverseArray(int[] array){
    int length = array.Length;
    int[] newArray = new int[length];
    
    for (int i = 0; i < length; i++)
    {
        newArray[length - 1 - i] = array[i];
    }
    return newArray;
}

int[] testArray = FillArray();
PrintArray(testArray);
PrintArray(reverseArray(testArray));
PrintArray(ReverseSwapArray(testArray));