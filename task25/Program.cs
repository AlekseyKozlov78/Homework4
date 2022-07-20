// Задача 25
// Напишите цикл, который принимает на вход два числа (А и В) и возводит число А в натуральную степень В.

double Result(int aLocal, int bLocal )
{
     return Math.Pow(aLocal, bLocal);
}
    
Console.WriteLine("Введите число A");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число B");
int b = int.Parse(Console.ReadLine());

Console.WriteLine(Result(a, b));
