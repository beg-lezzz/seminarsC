//int randomNum = new Random().Next(1,8);
//Console.WriteLine(randomNum);
Console.Clear();
Console.Write("Введите номер дня недели (число от 1 до 7): ");
string firstLine = Console.ReadLine();
string? answerDays, answerBig;
bool answer = true;

// функция для проверки вводимых пользователем данных на пустоту и null
bool nullCheck(string str)
{
    if (str == null || str == "")
    {
        answer = false;
    }
    return answer;
}

// функция для проверки вводимых пользователем данных на диапазон от 1 до 7
bool dayCheck(string str)
{
    int firstDig = int.Parse(firstLine);
    if (firstDig < 1 || firstDig > 7)
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
            if (dayCheck(firstLine) == true)
            {
                    answerBig = "ok";
            }
            else
            {
                answerBig = "Число не лежит в диапазоне номеров дней недели (от 1 до 7)";
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

    int numLine = int.Parse(firstLine);
// заполняем словарь днями недели и false/true для рабочих и выходных дней
    var weekDaysDict = new Dictionary<int, bool>()
    {
        { 1, false },
        { 2, false },
        { 3, false },
        { 4, false },
        { 5, false },
        { 6, true },
        { 7, true },
    };

// обращаемся к элементу словаря и получаем значение, на основе которого говорим да или нет
    if (weekDaysDict[numLine] == false)
    {
        answerDays = "Нет";
    }
    else
    {
        answerDays = "Да";
    }

    Console.WriteLine("В словаре это - " + answerDays); // выводим ответ

    var weekDayVacations = new List<int>() { 6, 7 }; // заполняем список

// проверяем совадает ли введенное число с элементами этого списка и получаем значение, на основе которого говорим да или нет
    if (weekDayVacations.Contains(numLine) == true)
    {
        Console.WriteLine("В списке это - Да");
    }
    else
    {
        Console.WriteLine("В списке это - Нет");
    }
}
else
{
    Console.WriteLine(answerBig);
}