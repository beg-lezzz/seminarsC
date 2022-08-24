// метод для запроса и обработки данных от пользователя (коэффициенты)
int[,] readFactors()
{
    int[,] factors = new int[3, 2];
    for (int i = 0; i < factors.GetLength(0); i++)
    {
        Console.Write($"Введите k{i + 1}: ");
        bool check = int.TryParse(Console.ReadLine(), out int k);
        if (check)
        {
            factors[i, 0] = k;
        }
        else
        {
            Console.WriteLine("Некорректный ввод");
            break;
        }
    }
    
    for (int i = 0; i < factors.GetLength(0); i++)
    {
        Console.Write($"Введите b{i + 1}: ");
        bool check = int.TryParse(Console.ReadLine(), out int b);
        if (check)
        {
            factors[i, 1] = b;
        }
        else
        {
            Console.WriteLine("Некорректный ввод");
            break;
        }
    }
    
    return factors;
}

// метод для подсчета площади треугольника по полученным данным
double CalcSquare(int[,] factors)
{
    double square = 0;
    double coordX1; double coordY1;
    double coordX2; double coordY2;
    double coordX3; double coordY3;

    if (factors[0, 0] - factors[1, 0] == 0 || factors[1,0] - factors[2,0] == 0 || factors[0,0] - factors[2,0] == 0)         // проверяем на исключения, чтобы расстояние между точками не равнялось нулю
    {
        Console.WriteLine("При таких коэффициентах возникает деление на ноль. Необходимо скорректировать.");
    }
    else
    {
        // решаем систему уроавнений, чтобы найти координаты Х и У
        coordX1 = (factors[1,1] - factors[0,1]) / (factors[0,0] - factors[1,0]);
        coordY1 = factors[0,0] * coordX1 + factors[0,1]; 
        coordX2 = (factors[2,1] - factors[1,1]) / (factors[1,0] - factors[2,0]);
        coordY2 = factors[1,0] * coordX2 + factors[1,1]; 
        coordX3 = (factors[2,1] - factors[0,1]) / (factors[0,0] - factors[2,0]);
        coordY3 = factors[2,0] * coordX3 + factors[2,1];

        // находим расстояния между точками (по формуле)
        double sideA = Math.Sqrt(Math.Pow((coordX2 - coordX1), 2) +                                                         //
                                 Math.Pow((coordY2 - coordY1), 2));
        double sideB = Math.Sqrt(Math.Pow((coordX3 - coordX2), 2) + 
                                 Math.Pow((coordY3 - coordY2), 2));
        double sideC = Math.Sqrt(Math.Pow((coordX3 - coordX1), 2) + 
                                 Math.Pow((coordY3 - coordY1), 2));
        // вычисляем половину периметра для формулы площади треугольника
        double halfPerimeter = (sideA + sideB + sideC) / 2;
        // вычисляем площадь треугольника по формуле
        square = Math.Sqrt(halfPerimeter * (halfPerimeter - sideA) * 
                           (halfPerimeter - sideB) *
                           (halfPerimeter - sideC));
    }
    
    return square;
}

double square = CalcSquare(readFactors());

if (square > 0)
{
    Console.WriteLine($"Площадь треугольника = {square}");
}
else
{
    Console.WriteLine("Треугольник не образуется.");
}