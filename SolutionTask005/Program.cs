// Console.WriteLine("Введите число: ");
// string? inputline = Console.ReadLine();
//
// if (inputline != null)
// {
//     int inputNumber = int.Parse(inputline);
//     int startNumber = inputNumber * -1;
//     string lineOutput = "";
//     while (startNumber < inputNumber)
//     {
//         lineOutput = lineOutput + startNumber + ", ";
//         startNumber++;
//     }
//
//     lineOutput = lineOutput + inputNumber;
//     Console.WriteLine(lineOutput);
// }

Console.WriteLine("Введите число: ");
string? inputline = Console.ReadLine();

if (inputline != null)
{
    int inputNumber = int.Parse(inputline);
    int startNumber = 1;
    string lineOutput = "0";
    while (startNumber <= inputNumber)
    {
        lineOutput = startNumber * -1 + ", " + lineOutput + ", " + startNumber;
        startNumber++;
    }
    
Console.WriteLine(lineOutput);
}