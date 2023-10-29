int Prompt (string message)
{
    System.Console.Write(message);
    string readInput = System.Console.ReadLine();
    int result = int.Parse(readInput);
    return result;
}

int SumAllDIgit(int number)
{
    int result = 0;
    while (number > 0)
    {
        result += number % 10;
        number = number / 10;
    }
    return result;
}

int number = Prompt("ВВЕдите число");
System.Console.WriteLine($"Сумма всех чисел в  цифре {number} = {SumAllDIgit (number)}");
