// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму 
//цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число");
string number = Console.ReadLine();
//int sum = 0;
string[] arr = number;
void PrintArray(string[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}");
    }
}
PrintArray(number);
// for (int i = 1; i<=number; i++)
// {
//     sum += i;
// }
// Console.WriteLine($"Cумма чисел: {sum}");