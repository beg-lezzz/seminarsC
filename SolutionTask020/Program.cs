int aX;
int aY;
int bX;
int bY;
double varAB;

void readDataOfPoint()
{
    Console.Write("Введите координату Х точки А: ");
    aX = int.Parse(Console.ReadLine());
    
    Console.Write("Введите координату Y точки А: ");
    aY = int.Parse(Console.ReadLine());
    
    Console.Write("Введите координату Х точки B: ");
    bX = int.Parse(Console.ReadLine());
    
    Console.Write("Введите координату Y точки B: ");
    bY = int.Parse(Console.ReadLine());    
}


void calculateVarAB()
{
    varAB = Math.Sqrt(Math.Pow((aX - bX),2) + Math.Pow((aY - bY),2));    
}

readDataOfPoint();
calculateVarAB();

Console.WriteLine("Расстояние между точками = " + varAB);