// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях (индексах).
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] GetArray(int size)
{
    Random rnd = new Random();
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(-100, 100);
    }
    return array;
}

void SumOddIndex(int[] arr)
{
    int Sum = 0;
    for (int i = 1; i < arr.Length; i = i + 2)
    {
        Sum = Sum + arr[i];
    }
    Console.WriteLine($" -> {Sum}");
}
void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

int[] array = GetArray(4);
PrintArray(array);
SumOddIndex(array);

