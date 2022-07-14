int randomNum = new Random().Next(1,8);
Console.WriteLine(randomNum);
string? answer;

var weekDaysDict = new Dictionary<int, bool>()
{
    {1, false},
    {2, false},
    {3, false},
    {4, false},
    {5, false},
    {6, true},
    {7, true},
};

if (weekDaysDict[randomNum] == false)
{
    answer = "Рабочий";
}
else
{
    answer = "Выходной";
}

Console.WriteLine("В словаре это - " + answer);

var weekDayVacations = new List<int>(){6,7};

if (weekDayVacations.Contains(randomNum) == true)
{
    Console.WriteLine("В списке это - Выходной");
}
else
{
    Console.WriteLine("В списке это - Рабочий");
}