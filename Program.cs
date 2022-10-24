/*

// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int FindSecondDigit (int number)
{
    int digit2 = (number /10) % 10;
    return digit2;
}

Console.WriteLine("Input number: ");
int num =Convert.ToInt32(Console.ReadLine());

if (num > 99 & num < 1000)
{
    int result = FindSecondDigit (num);
    Console.WriteLine($"The second digit of {num} is {result}");
}
else
{
    Console.WriteLine($"Non-three-digit number entered. Try again!");
}


//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

void FindThirdDigit (int number)
{
    if (number < 100)
    {
        Console.WriteLine($"No third digit");
    }
    else
    {
        int number1 = number;
        while (number > 1000)
        {
        number = number / 10;
        }
        int digit3 = (number % 10);
        Console.WriteLine($"The third digit of {number1} is {digit3}");
    }
}

Console.WriteLine("Input number: ");
int num =Convert.ToInt32(Console.ReadLine());

FindThirdDigit (num);


//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

bool CheckDays (int dayNum)
{
    if (dayNum == 6 || dayNum == 7) return true;
    return false;
}

Console.WriteLine("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

bool result = CheckDays (number);
if (result)
{
    Console.WriteLine($"The number {number} is a day off.");
}
else if (number < 1 || number > 7)
{
    Console.WriteLine("It's not a day of the week");
}
else
{
    Console.WriteLine($"The number {number} is not a day off.");
}

*/