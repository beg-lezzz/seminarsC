void printAnswer(int number)
{
    if (number == 1) Console.WriteLine("Допустимо: x > 0; y > 0");
    if (number == 2) Console.WriteLine("Допустимо: x < 0; y > 0");
    if (number == 3) Console.WriteLine("Допустимо: x < 0; y < 0");
    if (number == 4) Console.WriteLine("Допустимо: x > 0; y < 0"); 
}


Console.WriteLine("Введите номер четверти:");
string? inputline = Console.ReadLine();

if (inputline != null)
{
    int inputNumber = int.Parse(inputline);
    
    printAnswer(inputNumber);
}