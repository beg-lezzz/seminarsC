Console.Clear();
Console.Write("Введите число: ");

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
bool biggerOne(string str)
{
    bool answer = true;
    if (int.Parse(numStr) < 1)
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
                if (biggerOne(numStr) == true)
                {
                    answerBig = "ok";    
                }
                else
                {
                    answerBig = "Введенное число меньше 1";
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

// метод для определения максимального количества символов среди чисел
int maxNumber(int num)
{
    int maxDigits = 0;
    num = (int)Math.Pow(num, 3);
    while (num > 0)
    {
        num = num / 10;
        maxDigits++;
    }
    return maxDigits;
}

// метод для печати горизонтальных полос таблицы
void horizPrint(int num, int max)
{
    for (int i = 1; i <= (num*(max+3)+1); i++)
    {
        Console.Write("-");    
    }
    Console.WriteLine();
}

// метод для выведения строки чисел
void numPrint(int num, int max)
{
    Console.Write("|");
    for (int i = 1; i <= num; i++)
    {
        Console.Write(" {0, " + -max + "} |", i);        
    }
    Console.WriteLine();
}

// метод для выведения строки кубов
void numPowPrint(int num, int max)
{
    Console.Write("|");
    for (int i = 1; i <= num; i++)
    {
        Console.Write(" {0, " + -max + "} |", Math.Pow(i,3));        
    }
    Console.WriteLine();
}

if (checker(numStr) == "ok")
{
    int numLine = int.Parse(numStr);
    Console.Clear();
    Console.WriteLine("Таблица чисел от 1 до " + numLine + " и их кубов: ");
    horizPrint(numLine, maxNumber(numLine));
    numPrint(numLine,maxNumber(numLine));
    horizPrint(numLine, maxNumber(numLine));
    numPowPrint(numLine, maxNumber(numLine));
    horizPrint(numLine, maxNumber(numLine));
}
else
{
    Console.WriteLine(checker(numStr));
}