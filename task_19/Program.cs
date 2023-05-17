// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. 
// Через строку решать нельзя.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("введите 5-значное число");
int num = Convert.ToInt32(Console.ReadLine());
int result = 0;
int dubl = num;

if (num > 9999 & num < 100000)
{
    while (dubl > 0)
    {
        result = result * 10 + dubl % 10;
        dubl = dubl / 10;
    }

    if (num == result)
        Console.WriteLine("да");
    else
        Console.WriteLine("нет");
}
else
    Console.WriteLine("введите 5-значное число");