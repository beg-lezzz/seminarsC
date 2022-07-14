Console.Write("Введите трёхзначное число: ");
string? firstLine = Console.ReadLine(); 
bool answer = true;

bool nullCheck(string str)
{
    if (str == null || str == "")
    {
        answer = false;
    }
    return answer;
}
    
bool threeDigitCheck(string str)
{
    if (firstLine.Length != 3)
    {
        answer = false;
    }
    return answer;
}
    
bool zeroCheck(string str)
{
    char[] array = firstLine.ToString().ToCharArray();
    int firstDig = ((int)array[0]) - 48;
    if (firstDig == 0)
    {
        answer = false;
    }
    return answer;
}

bool intCheck(string str)
{
    int num;
    bool isNum = int.TryParse(firstLine, out num);
    return isNum;
}

if (nullCheck(firstLine) == true)
{
    if (intCheck(firstLine))
    {
        if (threeDigitCheck(firstLine) == true)
        {
            if (zeroCheck(firstLine) == true)
            {
                int secondDigit = int.Parse(firstLine);
                Console.WriteLine(secondDigit);
            }
            else
            {
                Console.WriteLine("Число не может начинаться с нуля");
            }
        }
        else
        {
            Console.WriteLine("Введенное число не трёхзначное");
        }
    }
    else
    {
        Console.WriteLine("Вы ввели не число");
    }
}
else
{
    Console.WriteLine("Вы ничего не ввели");;
}