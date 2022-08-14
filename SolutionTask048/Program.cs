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
            Console.Write(inputArray[i,j] + " ");
            // Console.Write(inputArray[i,j] + ", ");
            Console.ResetColor();
        }
        Console.WriteLine();
        // Console.ForegroundColor = col[new System.Random().Next(0,16)];
        // Console.WriteLine(inputArray[i, inputArray.GetLength(1) - 1]);
    }
}

void UpdateTwoDimArray(ref int[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1) - 1; j++)
        {
            inputArray[i, j] = i + j;
        }
    }
}

Console.Write("Введите кол-во строк: ");
int countRow = int.Parse(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int countColumn = int.Parse(Console.ReadLine());

int[,] bufArray = FillTwoDimArray(countRow, countColumn);

PrintColorTwoDimArray(bufArray);
UpdateTwoDimArray(ref bufArray);
Console.WriteLine();
PrintColorTwoDimArray(bufArray);