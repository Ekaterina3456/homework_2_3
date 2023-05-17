// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("введите число");
int num = Convert.ToInt32(Console.ReadLine());
int num1 = 1;
double result =0;

while (num1 <= num)
{
    result = Math.Pow(num1,3);
    Console.Write($"{result} ");
    num1++;
}