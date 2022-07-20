// Задача 29
// Напишите программу, которая задает массив из восьми элементов и выводит их на экран.

int[] getNewArray(int n)
{
    int[] array = new int[n];

    for (int i = 0; i < n; i++)
    {
        array[i] = int.Parse(Console.ReadLine());
    }
    return array; 
}

Console.WriteLine("Введите массив из восьми элементов");
int[] array = getNewArray(8);

foreach (int item in array)
    {
        Console.Write(item + " ");
    }
