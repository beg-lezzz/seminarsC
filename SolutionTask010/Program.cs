Console.Write("Введите трёхзначное число: ");
string? firstLine = Console.ReadLine(); 
bool answer = true;
string? answerCheck;

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
    if (firstDig == 0 && array.Length > 2)
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
                    answerCheck = "ok";
                }
                else
                {
                    answerCheck = "Введенное число не трёхзначное";
                }
            }
            else
            {
                answerCheck = "Число не может начинаться с нуля";
            }
        }
        else
        {
            answerCheck = "Вы ввели не число";
        }
    }
    else
    {
        answerCheck = "Вы ничего не ввели";
    }

    return answerCheck;
}

if (checker(firstLine) == "ok")
{ 
    int secondDigit = int.Parse(firstLine)%100/10; 
    Console.WriteLine(secondDigit);
}
else
{
    Console.WriteLine(answerCheck);
}