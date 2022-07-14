Console.WriteLine("Enter the number:");
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
    if (firstLine.Length < 3)
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
                int number = int.Parse(firstLine);
                int count = 0;

                while (number>0)
                {
                    var digit = number % 10;
                    number /= 10;
                    count++;
                }

                int[] arrNumber = new int[count];

                number = int.Parse(firstLine);
                while(number > 0)
                {
                    arrNumber[count-1] = number % 10;
                    number /= 10;
                    count--;
                }

                Console.WriteLine(arrNumber[2]);
            }
            else
            {
                Console.WriteLine("Число не может начинаться с нуля");
            }
        }
        else
        {
            Console.WriteLine("Введенное число содержит менее трёх цифр");
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