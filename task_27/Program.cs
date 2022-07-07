// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму 
//цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int number = Convert.ToInt32(Console.ReadLine());
int digit = 0;
int sumDigit = 0;
while (number != 0)
{
    digit = number % 10;
    sumDigit +=digit;
    number /= 10;
}
Console.WriteLine(sumDigit);
