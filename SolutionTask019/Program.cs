Console.Clear();
Console.Write("Введите пятизначное число: ");

string? numStr = Console.ReadLine();

// метод для проверки вводимых пользователем данных на пустоту и null
bool nullCheck(string str)
{
    bool answer = true;
    if (str == null || str == "")
    {
        answer = false;
    }
    return answer;
}

// метод для проверки вводимых пользователем данных на то, чтобы число было от единицы и больше
bool fiveDigitsCheck(string str)
{
    bool answer = true;
    if (numStr.Length != 5)
    {
        answer = false;
    }
    return answer;
}

// метод для проверки вводимых пользователем данных на то, чтобы число было больше нуля
bool biggerZero(string str)
{
    bool answer = true;
    if (int.Parse(numStr) < 0)
    {
        answer = false;
    }
    return answer;
}

// метод для проверки вводимых пользователем данных на наличие нуля в начале строки
bool zeroCheck(string str)
{
    bool answer = true;
    char[] array = numStr.ToString().ToCharArray();
    int firstDig = ((int)array[0]) - 48;
    if (firstDig == 0 && array.Length > 1)
    {
        answer = false;
    }
    return answer;
}

// метод для проверки вводимых пользователем данных на целое число
bool intCheck(string str)
{
    bool answer = true;
    int num;
    bool isNum = int.TryParse(numStr, out num);
    return isNum;
}

// метод, проводящий все проверки вводимых данных и возвращающая "ок", либо текст ошибки
string? checker(string str)
{
    string? answerBig = string.Empty;
    if (nullCheck(numStr) == true)
    {
        if (intCheck(numStr))
        {
            if (zeroCheck(numStr) == true)
            {
                if (fiveDigitsCheck(numStr) == true)
                {
                    if (biggerZero(numStr) == true)
                    {
                        answerBig = "ok";    
                    }
                    else
                    {
                        answerBig = "Введенное число меньше нуля";
                    }
                }
                else
                {
                    answerBig = "Длина введенного числа не равна 5";
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

// метод для заполнения словаря пятизначных палиндромов
Dictionary<string,string> dicFill()
{
    var dic = new Dictionary<string, string>();
    string? palindrom = string.Empty;
    for (int i = 0; i <= 9; i++)
    {
        for (int j = 0; j <= 9; j++)
        {
            for (int k = 1; k <= 9; k++)
            {
                palindrom = k.ToString() + j.ToString() + i.ToString() + j.ToString() + k.ToString();
                dic.Add(palindrom, palindrom);
            }
        }
    }

    return dic;
}

if (checker(numStr) == "ok")
{
    if (dicFill().ContainsKey(numStr) == true)
    {
        Console.WriteLine("Палиндром");
    }
    else
    {
        Console.WriteLine("Не палиндром");    
    }
}
else
{
    Console.WriteLine(checker(numStr));
}