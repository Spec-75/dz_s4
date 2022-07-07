//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
//возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число A");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
int B = Convert.ToInt32(Console.ReadLine());
int degree = A;
if (B > 0)
{
    for (int i = 2; i <= B; i++)
    
    {
        degree *=A;
    }
    Console.WriteLine($"Число {A} в степени {B} равно {degree}");
}
else
{
    Console.WriteLine($"Число {A} в степени {B} равно 1");
}

