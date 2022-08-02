Console.Write("Введите число: ");

int inputNumber = int.Parse(Console.ReadLine());
int t;

void VariantSimple()
{
    int sumOfNumbers = 0;
    for (int i = 1; i <= inputNumber; i++)
    {
        sumOfNumbers += i;
    }
    
    Console.WriteLine("Сумма чисел от 1 до " + inputNumber + " = " + sumOfNumbers);
}

void VariantGauss()
{
    int sumOfNumbers = 0;

    sumOfNumbers = ((inputNumber + 1) * inputNumber) / 2;
    
    Console.WriteLine("Сумма чисел от 1 до " + inputNumber + " = " + sumOfNumbers);
}

t = Environment.TickCount;

VariantSimple();

Console.WriteLine("Время выполнения: {0} мс", Environment.TickCount - t);

VariantGauss();