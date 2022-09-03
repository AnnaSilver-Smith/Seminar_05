// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int [] array = new int[size];
RandomNumbers(array);
void RandomNumbers(int[] array)
{
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(1, 10);
        Console.Write(array[i] + " ");
        
    }
}
Console.WriteLine();
int sum = 0;
for (int f = 0; f < array.Length; f+=2)
{
    sum += array[f];
}

Console.Write("Сумма нечетных чисел массива: " + sum);
Console.WriteLine();