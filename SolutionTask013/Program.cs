Console.WriteLine("Enter the number:");
string? firstLine = Console.ReadLine();
bool answer = true;
string? answerBig;

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
    if (firstDig == 0 && array.Length > 1)
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

string? checker(string str)
{
    if (nullCheck(firstLine) == true)
    {
        if (intCheck(firstLine))
        {
            if (zeroCheck(firstLine) == true)
            {
                if (threeDigitCheck(firstLine) == true)
                {
                    answerBig = "ok";
                }
                else
                {
                    answerBig = "Введенное число содержит менее трёх цифр";
                }
            }
            else
            {
                answerBig = "Число не может начинаться с нуля";
            }
        }
        else
        {
            answerBig = "Вы ввели не число";
        }
    }
    else
    {
        answerBig = "Вы ничего не ввели";
    }

    return answerBig;
}

if (checker(firstLine) == "ok")
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
    Console.WriteLine(answerBig);
}