//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите число: ");
string number = Console.ReadLine();
int A = number.Length;

if (A == 5)
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine($"{number} - да");
    }
    else
    {
        Console.WriteLine($"{number} - нет");
    }
}
else
{
    Console.WriteLine($"число не является пятизначным");
}
  