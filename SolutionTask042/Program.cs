Console.Write("Введите число: ");
DateTime d1 = DateTime.Now;
Console.WriteLine($"Число в двоичной системе = {Convert.ToString(int.Parse(Console.ReadLine()), 2)}");
Console.WriteLine(DateTime.Now - d1);

Console.Write("Введите число: ");
d1 = DateTime.Now;
int number = int.Parse(Console.ReadLine());
Console.WriteLine($"Число в восьмеричной системе = {Convert.ToString(number,8)}");
Console.WriteLine(DateTime.Now - d1);

Console.Write("Введите десятичное число: ");
d1 = DateTime.Now;
int decemalNumber = ReadDecemalNumber();
PrintAnswer(BinaryConverter(decemalNumber));


int ReadDecemalNumber(){
    return int.Parse(Console.ReadLine() ?? "");
}

string BinaryConverter(int num) {
    string bin = "";
    while(num > 0) {
        if (num % 2 == 1) {
            bin = "1" + bin;
        } else {
            bin = "0" + bin;            
        }
        num /= 2;
    }
    return bin;
}

void PrintAnswer(string answer){
    Console.WriteLine("Введенное число в двоичном виде: " + answer);
}
Console.WriteLine(DateTime.Now - d1);