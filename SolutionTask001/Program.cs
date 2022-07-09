string? inputline = Console.ReadLine();

if (inputline != null)
{
    int inputnumber = int.Parse(inputline);
    // int outnumber = inputnumber * inputnumber;
    int outnumber = (int)Math.Pow(inputnumber,2);
    Console.WriteLine(outnumber);
}