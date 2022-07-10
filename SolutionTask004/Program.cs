// Console.Write("Введите первое число: ");
// string? inputLineA = Console.ReadLine();
// Console.Write("Введите второе число: ");
// string? inputLineB = Console.ReadLine();
// Console.Write("Введите третье число: ");
// string? inputLineC = Console.ReadLine();
//
// if (inputLineA != null && inputLineB != null && inputLineC != null)
// {
//     int inputNumberA = int.Parse(inputLineA);
//     int inputNumberB = int.Parse(inputLineB);
//     int inputNumberC = int.Parse(inputLineC);
//     int max = inputNumberA;
//     
//     if (max < inputNumberB)
//     {
//         if (inputNumberB < inputNumberC)
//         {
//             max = inputNumberC;
//         }
//         else
//         {
//             max = inputNumberB;
//         }
//     }
//     else
//     {
//         if (max < inputNumberC)
//         {
//             max = inputNumberC;
//         }
//     }
//     
//     Console.Write(max);
// }

int count = 0;
int[] arrNumbber = new int[3];
string? inputLine = "";
int max = 0;

while (count < 3)
{
    Console.Write("Введите " + (count + 1) + " число: ");
    inputLine = Console.ReadLine();
    if (inputLine != "" && inputLine != null)
    {
        arrNumbber[count] = int.Parse(inputLine);
        if (count == 0)
        {
            max = arrNumbber[0];
        }
        else
        {
            if (max < arrNumbber[count])
            {
                max = arrNumbber[count];
            }
        }
        count++;
    }
    else
    {
        Console.WriteLine("Вы ничего не ввели. Повторите ввод.");
    }
}

Console.WriteLine(max);