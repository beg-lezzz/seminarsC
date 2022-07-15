Console.Clear();
Console.Write("Введите трёхзначное число: ");
string? firstLine = Console.ReadLine(); 
bool answer = true;
string? answerCheck;

// функция для проверки вводимых пользователем данных на пустоту и null
bool nullCheck(string str)
{
    if (str == null || str == "")
    {
        answer = false;
    }
    return answer;
}

// функция для проверки вводимых пользователем данных на количество введенных символов
bool threeDigitCheck(string str)
{
    if (firstLine.Length != 3)
    {
        answer = false;
    }
    return answer;
}

// функция для проверки вводимых пользователем данных на наличие нуля в начале строки
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

// функция для проверки вводимых пользователем данных на целое число
bool intCheck(string str)
{
    int num;
    bool isNum = int.TryParse(firstLine, out num);
    return isNum;
}

// функция, проводящая все проверки вводимых данных и возвращающая "ок", либо текст ошибки
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

//определение второй цифры введенного числа
if (checker(firstLine) == "ok")
{ 
    int secondDigit = int.Parse(firstLine)%100/10; 
    Console.WriteLine(secondDigit); // вывод второй цифры
}
else
{
    Console.WriteLine(answerCheck); // вывод текста ошибки
}