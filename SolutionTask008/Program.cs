Console.Write("Введите число: ");
string? inputLine = Console.ReadLine();

if (inputLine != null && inputLine != "" && int.Parse(inputLine) > 1)
{
    int inputNumber = int.Parse(inputLine);
    int startNumber = 2;
    int counter = 1;
    string outputString = "";

    while (startNumber < inputNumber + 1)
    {
        if (counter == inputNumber / 2)
        {
            outputString = outputString + startNumber;
            startNumber = startNumber + 2;
            counter++;
        }
        else
        {
            outputString = outputString + startNumber + ", ";
            startNumber = startNumber + 2;
            counter++;
        }
    }

    Console.WriteLine(outputString);
    
    // counter = 0;
    // int[] arrNumber = new int[inputNumber / 2];
    // while (startNumber < inputNumber + 1)
    // {
    //     arrNumber[counter] = startNumber;
    //     counter++;
    //     startNumber = startNumber + 2;
    // }
    //
    // counter = 0;
    // while (counter < arrNumber.Length)
    // {
    //     if (counter == arrNumber.Length - 1)
    //     {
    //         Console.Write(arrNumber[counter]);
    //         counter++;
    //     }
    //     else
    //     {
    //         Console.Write(arrNumber[counter] + ", ");
    //         counter++;
    //     }
    // }
}