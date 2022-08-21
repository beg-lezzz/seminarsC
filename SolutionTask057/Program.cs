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
            outArray[i, j] = numberSyntezator.Next(0, 10);
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

//Метод для печати одномерного массива
void PrintIntArray(int[] inputArray)
{
    //Буфферная переменная
    int i = 0;
    //Пробегаем все элементы массива
    while (i < inputArray.Length - 1)
    {
        //Выводим элемент массива
        Console.Write(i + "\t");
        //Увеличиваем инкремент
        i++;
    }
    //Выводим элемент массива
    Console.WriteLine(i);
    
    //Буфферная переменная
    i = 0;
    //Пробегаем все элементы массива
    while (i < inputArray.Length - 1)
    {
        //Выводим элемент массива
        Console.Write(inputArray[i] + "\t");
        //Увеличиваем инкремент
        i++;
    }
    //Выводим элемент массива
    Console.WriteLine(inputArray[i]);
}

// Метод меняет местами первую ипоследнюю строчку
// Принимает двумерный массив
// Возвращает модефицированный входной массив
int[] FreqmancyCollect(int[,] inputArray, int alphabetLength)
{
    int[] resultArray = new int[alphabetLength];
    int i = 0; int j = 0;
    while (i < inputArray.GetLength(0))
    {
        j = 0;
        while (j < inputArray.GetLength(0))
        {
            //Собираем частоту появления элементов
            resultArray[inputArray[i,j]]++;
            j++;
        }
        i++;
    }
    return resultArray;
}


int[,] twoDimArray = FillTwoDimArray(10, 10);
PrintTwoDimArray(twoDimArray);
Console.WriteLine();

int[] freqmancy = FreqmancyCollect(twoDimArray,10);
PrintIntArray(freqmancy);