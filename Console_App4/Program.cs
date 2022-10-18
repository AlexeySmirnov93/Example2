//Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
System.Console.WriteLine("Введите число N:");
int n = Convert.ToInt32(Console.ReadLine());

int negativN = n * -1;

while(negativN <= n)
{
    System.Console.WriteLine(negativN);
    negativN = negativN +1;
}
