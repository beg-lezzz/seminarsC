Console.Write("Введите число: ");
string? inputLine = Console.ReadLine();

if (inputLine != null)
{
    double inputNumber = double.Parse(inputLine);
    double divResult = inputNumber / 2;
    
    if (divResult.ToString().Contains(","))
    {
        Console.WriteLine("Нет");
    }
    else
    {
        Console.WriteLine("Да");
    }

    // int inputNumber = int.Parse(inputLine);
    //  if (inputNumber % 2 == 0)
    //  {
    //      Console.WriteLine("Да");
    //  }
    //  else
    //  {
    //      Console.WriteLine("Нет");
    //  }
}