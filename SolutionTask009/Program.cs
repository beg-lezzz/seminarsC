void variant1()
{
    int number = new Random().Next(10, 100);
    int firstNum = number/10;
    int secondNum = number%10;
    int max;

    Console.WriteLine("Число: " + number);

    if (firstNum > secondNum)
    {
        max = firstNum;
    }
    else
    {
        max = secondNum;
    }

    Console.Write("Максимальное число: " + max);
}

// char[] number = new Random().Next(10, 100).ToString().ToCharArray();
// int count = 0;
// int max = -1;
// string digit = "";
//
// while (count < number.Length - 1)
// {
//     if (number[count] > max)
//     {
//         max = number[count];
//     }
//     digit = digit + number[count];
//     count++;
// }
//
// Console.WriteLine(max + " " + digit);

void variant2()
{
    int number = new Random().Next(10, 100);
    Console.Write("The random number is: ");
    Console.WriteLine(number);
    string stringNum = number.ToString();
    Console.Write("The biggest digit is : ");
    if (stringNum[0] > stringNum[1]) 
    {
        Console.WriteLine(stringNum[0]);
    } else
    {
        Console.WriteLine(stringNum[1]);
    } 
}

variant1();

variant2();