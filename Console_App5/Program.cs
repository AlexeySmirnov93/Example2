//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
Console.WriteLine("Введите чило: ");
int n = Convert.ToInt32(Console.ReadLine());
int min = 99;
int max = 1000;
if (n > min && n < max)
{
    int result = n % 10;
    Console.WriteLine( $"Последняя цифра трехзначного числа: {result}");
}
else
{
    Console.WriteLine($"Данное число не является трехзначным: {n}");
}
