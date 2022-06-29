// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Enter three-digit number");
int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
// int secondDigit = threeDigitNumber / 10 % 10;
int secondDigit = threeDigitNumber % 100 / 10;
Console.WriteLine($"Second number is: {secondDigit}");
