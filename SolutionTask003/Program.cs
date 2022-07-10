using System.ComponentModel.Design;

Console.Write("Введите номер дня недели: ");
string? inputLine = Console.ReadLine();

if (inputLine != null)
{
    int inputNumber = int.Parse(inputLine);
    // string[] dayOfWeek = new string[7];
    // dayOfWeek[0] = "Понедельник";
    // dayOfWeek[1] = "Вторник";
    // dayOfWeek[2] = "Среда";
    // dayOfWeek[3] = "Четверг";
    // dayOfWeek[4] = "Пятница";
    // dayOfWeek[5] = "Суббота";
    // dayOfWeek[6] = "Воскресенье";

    switch (inputNumber)
    {
        case 1: Console.WriteLine("Понедельник");
        break;
        case 2: Console.WriteLine("Вторник");
        break;
        case 3: Console.WriteLine("Среда");
        break;
        case 4: Console.WriteLine("Четверг");
        break;
        case 5: Console.WriteLine("Пятница");
        break;
        case 6: Console.WriteLine("Суббота");
        break;
        case 7: Console.WriteLine("Воскресенье");
        break;
    }
    
    //Console.WriteLine(dayOfWeek[inputNumber - 1]);
}