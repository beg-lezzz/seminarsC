void first()
{
    Console.Write("Enter first number: ");
    string? firstLine = Console.ReadLine();
    Console.Write("Enter second number: ");
    string? secondLine = Console.ReadLine();
    int first = int.Parse(firstLine);
    int second = int.Parse(secondLine);
    if (firstLine != null && secondLine != null)
    {
        if (second % first == 0)
        {
            Console.WriteLine("Кратное");
        }
        else
        {
            Console.WriteLine("Не кратное, " + second % first);
        }
    }
}

void second()
{
    Console.WriteLine("Input two numbers: ");

    string? inputOne = Console.ReadLine();
    string? inputTwo = Console.ReadLine();

    string reminderSearcher(string str1, string str2)
    {
        if (inputOne != null && inputTwo != null)
        {
            try
            {
                string answer;
                int num1 = int.Parse(str1);
                int num2 = int.Parse(str2);
                int remainder = num2 % num1;
                if (remainder != 0)
                {
                    answer = "The remainder is : " + remainder;
                }
                else
                {
                    answer = "It's multiple!!!";
                }

                return answer;
            }
            catch (Exception e)
            {
                return "Возникло исключение: " + e.Message;
            }
        }

        return "";
    }

    Console.WriteLine(reminderSearcher(inputOne, inputTwo));
}

first();
second();