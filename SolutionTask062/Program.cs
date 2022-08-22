// метод для заполнения двумерного массива по спирали
int[,] FillTwoDimArray(int countRow, int countColumn)
{
    int[,] inputArray = new int[countRow,countColumn];
    int left = 0, right = inputArray.GetLength(1) - 1, up = 0, down = inputArray.GetLength(0) - 1;
    int count = 1;
    string route = "fromLeftToRight";
    int size = countColumn * countRow;

    while (count <= size)
    {
        switch (route)
        {
            case "fromLeftToRight":
                for (int i = left; i <= right; i++)
                {
                    inputArray[up, i] = count;
                    count++;
                }
                up++;
                route = "fromTopToDown";
            
                break;
            case "fromTopToDown":
            {
                for (int i = up; i <= down; i++)
                {
                    inputArray[i, right] = count;
                    count++;
                }
                right--;
                route = "fromRightToLeft";
            }
                break;
            case "fromRightToLeft":
            {
                for (int i = right; i >= left; i--)
                {
                    inputArray[down, i] = count;
                    count++;
                }
                down--;
                route = "fromDownToTop";
            }
                break;
            case "fromDownToTop":
            {
                for (int i = down; i >= up; i--)
                {
                    inputArray[i, left] = count;
                    count++;
                }
                left++;
                route = "fromLeftToRight";
            }
                break;
        }
    }
    
    return inputArray;
}

// метод для печати двумерного массива
void PrintTwoDimArray(int[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write(inputArray[i,j] + "\t");
        }
        Console.WriteLine();
    }
}

// метод для запроса данных у пользователя
int UserData(string inputString)
{
    Console.Write(inputString + ": ");
    string numString = Console.ReadLine();
    if (Int32.TryParse(numString, out int num) == true && num > 0)                                       //проверяем, что введено положительное число для строк
    {
        return num;
    }
    else
    {
        Console.WriteLine("Ошибка ввода");
        System.Environment.Exit(1);
        return 0;
    }
}

Console.Clear();
int arrCountRow = UserData("Введите число строк");
int arrCountCol = UserData("Введите число столбцов");

PrintTwoDimArray(FillTwoDimArray(arrCountRow, arrCountCol));