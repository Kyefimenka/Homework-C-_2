// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.n

int digit = 0;
while(digit < 1 || digit > 7)
{
    Console.WriteLine("Enter digit in [1..7]");
    digit = Convert.ToInt32(Console.ReadLine());
}
if(digit >= 5)
{
    Console.WriteLine("This is a weekday");
}
else
{
    Console.WriteLine("This is the weekend");
}

