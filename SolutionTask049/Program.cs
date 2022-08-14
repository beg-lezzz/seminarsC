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

ConsoleColor[] col = new ConsoleColor[]
{
    ConsoleColor.Black, ConsoleColor.Blue, ConsoleColor.Cyan,
    ConsoleColor.Gray, ConsoleColor.Green, ConsoleColor.Magenta,
    ConsoleColor.Red, ConsoleColor.White, ConsoleColor.Yellow,
    ConsoleColor.DarkBlue, ConsoleColor.DarkCyan, ConsoleColor.DarkGray,
    ConsoleColor.DarkGreen, ConsoleColor.DarkMagenta, ConsoleColor.DarkRed,
    ConsoleColor.DarkYellow
};

void PrintColorTwoDimArray(int[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1) - 1; j++)
        {
            Console.ForegroundColor = col[new System.Random().Next(0,16)];
            Console.Write(inputArray[i,j] + "\t");
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}

int[,] UpdateTwoDimArray(int[,] inputArray)
{
    int[,] outArray = new int[inputArray.GetLength(0),inputArray.GetLength(1)];
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1) - 1; j++)
        {
            if (i % 2 == 0 && j % 2 ==0)
            {
                outArray[i, j] = inputArray[i, j] * inputArray[i, j];
            }
            else
            {
                outArray[i, j] = inputArray[i, j];
            }
        }
    }

    return outArray;
}

void UpdateTwoDimArraySecondVersion(ref int[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i+=2)
    {
        for (int j = 0; j < inputArray.GetLength(1) - 1; j+=2)
        {
            if (i % 2 == 0 && j % 2 ==0)
            {
                inputArray[i, j] = inputArray[i, j] * inputArray[i, j];
            }
        }
    }
}

Console.Write("Введите кол-во строк: ");
int countRow = int.Parse(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int countColumn = int.Parse(Console.ReadLine());

int[,] twoDimArray = FillTwoDimArray(countRow, countColumn);
PrintColorTwoDimArray(twoDimArray);
Console.WriteLine();

DateTime d = DateTime.Now;
int[,] bufArray = UpdateTwoDimArray(twoDimArray);
Console.WriteLine(DateTime.Now - d);

d = DateTime.Now;
UpdateTwoDimArraySecondVersion(ref twoDimArray);
Console.WriteLine(DateTime.Now - d);

Console.WriteLine();
PrintColorTwoDimArray(bufArray);
Console.WriteLine();
PrintColorTwoDimArray(twoDimArray);
