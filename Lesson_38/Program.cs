// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
double [] array = new double[size];
double max = Int32.MinValue;
double min = Int32.MaxValue;
RandomNumbers(array);
void RandomNumbers(double[] array)
{
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(-999, 999);
        Console.Write(array[i] + ", ");
        
    }
}
Console.WriteLine();
for (int f = 0; f < array.Length; f++)
{
    if (array[f] > max)
    {
        max = array[f];
    }
    if (array[f] < min)
    {
        min = array[f];
    }
}

Console.WriteLine($"Max = {max}, Min = {min}");
Console.WriteLine($"Разница между Max и Min значением = {max - min}");