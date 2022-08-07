Console.WriteLine("Калькулятор. Доступные операции: ");
Console.WriteLine("Сумма: " + " + ");
Console.WriteLine("Разность: " + " - ");
Console.WriteLine("Произведение: " + " * ");
Console.WriteLine("Частное: " + " / ");
Console.WriteLine("Степень: " + " ^ ");
Console.Write("Введите два числа и операцию. Например, 5 + 2: ");

string? strForCalc = Console.ReadLine().Replace(" ", String.Empty); // считываем строку из консоли и удаляем лишние пробелы

// метод определения операции над числами и индекса оператора
string[] OperationFind(string strForCalc)
{
    string operation = String.Empty;
    int counter = 0;
    int indexOfOperator = 0;
    foreach (char c in strForCalc)
    {
        if (char.IsNumber(c) != true)
        {
            operation = c.ToString();
            counter++;
            indexOfOperator = strForCalc.ToString().IndexOf(c);
        }
    }
    string[] operationArray = new string[3];
    operationArray[0] = operation;
    operationArray[1] = counter.ToString();
    operationArray[2] = indexOfOperator.ToString();

    return operationArray;
}

//метод определения действия по оператору
string OperationCase(string operation, int firstNum, int secondNum)
{
    int result = 0;
    switch (operation)
    {
        case "+": result = firstNum + secondNum;
            break;
        case "-": result = firstNum - secondNum;
            break;
        case "*": result = firstNum * secondNum;
            break;
        case "/": result = firstNum / secondNum;
            break;
        case ":": result = firstNum / secondNum;
            break;
        case "^": result = (int)(Math.Pow(firstNum,secondNum));
            break;
    }

    return result.ToString();
}

// метод проверки массива с оператором на корректность введенных пользователем данных
bool ArrayCheck(string[] operationArray)
{
    bool check = false;
    string operation = operationArray[0];
    int counter = int.Parse(operationArray[1]);
    int indexOfOperator = int.Parse(operationArray[2]);
    if ((operation != string.Empty && counter != 0 && indexOfOperator != 0) || (counter == 1 || indexOfOperator != 0))
    {
        check = true;
    }

    return check;
}

// метод для вычисления результата операции с введенными числами
string Calculate(string[] operationArray)
{
    string resultOper = String.Empty;
    if (ArrayCheck(operationArray) == true)
    {
        string operation = operationArray[0];
        int counter = int.Parse(operationArray[1]);
        int indexOfOperator = int.Parse(operationArray[2]);
        
        int firstNum = int.Parse(strForCalc.Substring(0, indexOfOperator));
        int secondNum = int.Parse(strForCalc.Substring(indexOfOperator + 1));

        if (counter != 1 || indexOfOperator == 0)
        {
            resultOper = "Некорректно введены данные";
        }
        else if (operation == "/" && secondNum == 0)
        {
            resultOper = "На ноль делить нельзя";
        }
        else
        {
            resultOper = $"{strForCalc} = {OperationCase(operation, firstNum, secondNum)}";
        }
    }
    else
    {
        resultOper = "Некорректно введены данные";
    }

    return resultOper;
    }

Console.WriteLine(Calculate(OperationFind(strForCalc)));