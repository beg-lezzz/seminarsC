// метод для заполнения двумерного массива
int[,] FillTwoDimArray(int countRow, int countColumn)
{
    System.Random numberSyntezator = new System.Random();
    int i = 0; int j = 0;
    int[,] outArray = new int[countRow, countColumn];
    while (i < countRow)
    {
        j = 0;
        while (j < countColumn)
        {
            outArray[i, j] = numberSyntezator.Next(0, 101);
            j++;
        }
        i++;
    }
    return outArray;
}

// метод для печати двумерного массива
void PrintTwoDimArray(int[,] inputArray)
{
    int i = 0; int j = 0;

    while (i < inputArray.GetLength(0))
    {
        j = 0;
        while (j < inputArray.GetLength(1))
        {
            Console.Write(inputArray[i, j] + "\t");
            j++;
        }
        //Console.Write("\n");
        Console.WriteLine();
        i++;
    }
}

// Метод меняет местами первую ипоследнюю строчку
int[,] RotateRowFirstLast(int[,] inputArray)
{
    int bufElement = 0;
    int i = 0; int j = 0;
    while (j < inputArray.GetLength(1))
    {
        bufElement = inputArray[0, j];
        inputArray[0, j] = inputArray[inputArray.GetLength(0) - 1, j];
        inputArray[inputArray.GetLength(0) - 1, j] = bufElement;
        j++;
    }
    return inputArray;
}


int[,] twoDimArray = FillTwoDimArray(3, 4);
PrintTwoDimArray(twoDimArray);

Console.WriteLine();
PrintTwoDimArray(RotateRowFirstLast(twoDimArray));