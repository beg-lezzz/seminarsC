// Метод считывает точки и возвращает массив с ними
 int[,] readPoint()
 {
    string inputLine = Console.ReadLine();
    int[,] arrayCoord = new int[2, 3];
    
    //A(3,6,8); B(2,1,-7) -> 15.84

    string coordALine = inputLine.Substring(inputLine.IndexOf("(")+1, inputLine.IndexOf(")") - 2);

    string coordBLine = inputLine.Substring(inputLine.IndexOf(";"));
    coordBLine = coordBLine.Substring(coordBLine.IndexOf("(") + 1, coordBLine.IndexOf(")") - 4);

    string[] subsA = coordALine.Split(",");
    string[] subsB = coordBLine.Split(",");
    for (int i = 0; i < subsA.Length; i++)
    {
        arrayCoord[0, i] = int.Parse(subsA[i]);
        arrayCoord[1, i] = int.Parse(subsB[i]);
    }
    return arrayCoord;
}

//метод находит расстояние между точками
 void midPoints(int[,] arrayCoord)
 {
     double mid = Math.Sqrt(Math.Pow((arrayCoord[0, 0] - arrayCoord[1, 0]), 2) + Math.Pow((arrayCoord[0, 1] - arrayCoord[1, 1]), 2) + Math.Pow((arrayCoord[0, 2] - arrayCoord[1, 2]), 2));
     mid = Math.Round(mid, 2);
     Console.WriteLine("Расстояние между точками = " + mid);
 }
 
 Console.Clear();
 Console.Write("Введите координаты точки А и В в формате A(x,y,z); B(x,y,z): ");
 midPoints(readPoint());