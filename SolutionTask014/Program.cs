void findDiv()
{
    Console.Write("Enter number: ");
    string? firstLine = Console.ReadLine();
    int first = int.Parse(firstLine);


    if (first%7 == 0 && first%23 == 0)
    {
        Console.WriteLine("Кратное");
    }
    else
    {
        Console.WriteLine("Не кратное");
    }    
}

findDiv();

Console.WriteLine("Input number: ");

string? inputOne = Console.ReadLine();

string reminderSearcher(string str)
{
    if (inputOne != null)
    {
        try {
            string answer;
            int num = int.Parse(str);
            if (((num % 7) == 0) && ((num % 23) == 0)){
                answer = "It's multiple for 7 and 23";
            } else {
                answer = "It's not multiple for 7 and 23";
            }
            return answer;
        }
        catch(Exception e)
        {
            return "Возникло исключение: " + e.Message;
        }
    }
    return "";
}

Console.WriteLine(reminderSearcher(inputOne));