Console.Write("Введите число, которое хотите возвести в квадрат: ");
string? inputline = Console.ReadLine();

if (inputline != null)
{
    int inputnumber = int.Parse(inputline);
    // int outnumber = inputnumber * inputnumber;
    int outnumber = (int)Math.Pow(inputnumber,2);
    Console.Write("Квадрат введенного числа = ", outnumber);
    Console.WriteLine(outnumber);
}