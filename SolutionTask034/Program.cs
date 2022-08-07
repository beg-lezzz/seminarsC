// метод для заполнения массива
int[] FillArray(int arrLength)
{
    int[] inputArray = new int[arrLength];
    int i = 0;
    System.Random numberSyntezator = new System.Random();
    while (i < arrLength)
    {
        inputArray[i] = numberSyntezator.Next(100,1000);
        i++;
    }

    return inputArray;
}

// метод подсчета количества четных элементов
int EvenCount(int[] inputArray)
{
    int evenCount = 0;

    for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i]%2 == 0)
        {
            evenCount++;
        }
    }

    return evenCount;
}

// метод печати массива
void PrintArray(int[] inputArray)
{
    for (int i = 0; i < inputArray.Length - 1; i++)
    {
        Console.Write(inputArray[i] + ", ");
    }
    Console.WriteLine(inputArray[inputArray.Length - 1]);
}

// сортировка методом пузырька с печатью первоначального массива
int[] Bubble(int[] inputArray)
{
    Console.WriteLine("Сортировка методом пузырька: ");
    int[] outputArray = new int[inputArray.Length];
    int tmp;                                                        // задаем буферную переменную
    int k = 0;                                                      // задаем счетчик количества проходов внешнего цикла, чтобы уменьшать верхнюю границу, т.к. после каждого прохода
                                                                    // максимальный элемент оказывается в конце и к нему уже не нужно возвращаться
                                                                    
    for (int i = 0; i < inputArray.Length; i++)                     // запускаем внешний цикл для того, чтобы пройти последовательно по всем элементам массива
    {
        for (int j = 0; j < inputArray.Length - 1 - k; j++)         // запускаем внутренний цикл для того, чтобы последовательно сравнивать элементы массива в каждой итеррации внешнего цикла
        {
            if (inputArray[j] > inputArray[j + 1])                  // условие для "перетаскивания" вправо максимального элемента
            {
                tmp = inputArray[j];
                inputArray[j] = inputArray[j + 1];
                inputArray[j + 1] = tmp;
            }
        }

        k++;
    }
    return inputArray;
}

Console.Clear();
Console.WriteLine("Введите количество элементов массива: ");
string input = Console.ReadLine();
if (Int32.TryParse(input, out var arrLength) == true)
{
    int[] inputArray = new int[arrLength];
    inputArray = FillArray(arrLength);
    Console.WriteLine();
    Console.WriteLine("Исходный массив: ");
    PrintArray(inputArray);
    Console.WriteLine();
    Console.WriteLine($"Количество четных элементов в массиве: {EvenCount(inputArray)}");
    Console.WriteLine();
    PrintArray(Bubble(inputArray));
}
else
{
    Console.WriteLine("Некорректный ввод.");
}