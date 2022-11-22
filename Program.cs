Console.Clear();
Console.Write("введи первое число: ");
int number_one = int.Parse(Console.ReadLine());
Console.Write("введи второе число: ");
int number_two = int.Parse(Console.ReadLine());
int max = 0;
if (number_one>number_two)
{
    max = number_one;
}
else
{
    max = number_two;
}
Console.WriteLine($"максимальное число: {max}");