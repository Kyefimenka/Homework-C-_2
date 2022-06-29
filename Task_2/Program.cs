// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Enter number");
int curentNumber = Convert.ToInt32(Console.ReadLine());

if (curentNumber / 100 == 0)
{
    Console.WriteLine("Third digit not available");
}
else
{
    while (curentNumber / 1000 != 0)
    {
        curentNumber /= 10;
    }
    Console.WriteLine(curentNumber % 10);
}

