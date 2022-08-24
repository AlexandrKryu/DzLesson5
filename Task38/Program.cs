// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] GetArray(int size, int min, int max)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.NextDouble() * (max - min) * min;
    }
    return array;
}
void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{Math.Round(array[i], 2)}, ");
    }
    Console.Write("]");
}

void RazMaxMin(double[] arr)
{
    double raz = 0;
    double max = arr[0];
    double min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
        min = max;
        for (int j = 0; j < arr.Length; j++)
        {
            if (arr[j] < min) min = arr[j];
        }
    }   

    Console.WriteLine($"-> {Math.Round(raz=max-min, 2)}");
}

double[] array = GetArray(5, 1, 7);
PrintArray(array);
RazMaxMin(array);