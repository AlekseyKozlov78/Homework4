// Задача 27
// Напишите программу, которая принимает на вход число и выдает сумму цифр в числе

int getSumNum(int num)
{
    int sum = 0;
    int numLocal = 0;
    while (num > 0)
    {
        numLocal = num % 10;
        sum = sum + numLocal;
        num = num / 10;
    }
    return sum;
}

Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());

Console.WriteLine(getSumNum(num));

