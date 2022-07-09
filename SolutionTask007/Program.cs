Console.WriteLine("Введите число: ");
string? inputline = Console.ReadLine();

if (inputline != null && inputline.Length == 3)
{
    // int inputNumber = int.Parse(inputline);
    // int last = inputNumber%10;
    // string last = inputline.Substring(2, 1);
    char[] last = inputline.ToCharArray();
    Console.WriteLine(last[2]);
}