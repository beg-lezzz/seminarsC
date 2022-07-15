Console.Clear();
Console.WriteLine("Enter the number:");
string? firstLine = Console.ReadLine();
bool answer = true;
string? answerBig;

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
    if (firstLine.Length < 3)
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
    
// запускаем цикл для подсчета количества символов в числе
    while (number > 0)
    {
         var digit = number % 10;
         number /= 10;
         count++;
    }

// объявляем массив для хранения цифр числа с посчитанной выше размерностью
    int[] arrNumber = new int[count];

    number = int.Parse(firstLine);
    
// запускаем цикл для заполнения массива цифрами введенного числа
    
    while(number > 0)
    {
         arrNumber[count-1] = number % 10;
         number /= 10;
         count--;
    }

    
    Console.WriteLine(arrNumber[2]); // выводим третий элемент массива (третью цифру)
}
else
{
    Console.WriteLine(answerBig); // выводим текст ошибки
}