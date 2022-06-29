// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Enter number");
string strNumber = Console.ReadLine();

if(strNumber.Length < 3 || '0' > strNumber[2] || strNumber[2] > '9')
{
    Console.WriteLine("Third digit not available");
}
else
{
    Console.WriteLine(strNumber[2]);
}





