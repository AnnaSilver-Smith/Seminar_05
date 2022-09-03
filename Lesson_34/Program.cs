// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int [] array = new int[size];
RandomNumbers(array);
void RandomNumbers(int[] array)
{
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 999);
        Console.Write(array[i] + " ");
        
    }
}
Console.WriteLine();
int count = 0;
for (int f = 0; f < array.Length; f++)
{
    if (array[f] % 2 == 0)
    count++;
}

Console.Write("Колличество четных чисел массива: " + count);
Console.WriteLine();