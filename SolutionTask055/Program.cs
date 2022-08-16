int[,] FillTwoDimArray(int countRow, int countColumn)
{
    int[,] inputArray = new int[countRow,countColumn];

    System.Random numberSyntezator = new System.Random();

    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            inputArray[i, j] = numberSyntezator.Next(10, 100);
        }
    }

    return inputArray;
}

void PrintTwoDimArray(int[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write(inputArray[i,j] + " ");
            // Console.Write(inputArray[i,j] + ", ");
        }
        Console.WriteLine();
        //Console.WriteLine(inputArray[i, inputArray.GetLength(1) - 1]);
    }
}

int[,] RotateTwoDimArray(int[,] inputArray)
{
    int bufferElement = 0;
    int i = 0;
    int j = 0;
    while (i < inputArray.GetLength(0))
    {
        j = i;
        while (j<inputArray.GetLength(1))
        {
            bufferElement = inputArray[i,j];
            inputArray[i, j] = inputArray[j,i];
            inputArray[j, i] = bufferElement;
            j++;
        }

        i++;
    }

    return inputArray;
}

int[,] twoDimArray = FillTwoDimArray(3, 3);
PrintTwoDimArray(twoDimArray);
Console.WriteLine();

if (twoDimArray.GetLength(0) != twoDimArray.GetLength(1))
{
    Console.WriteLine("Данный массив перевернуть нельзя!");
}
else
{
    int[,] resultArr = RotateTwoDimArray(twoDimArray);
    PrintTwoDimArray(resultArr);
}