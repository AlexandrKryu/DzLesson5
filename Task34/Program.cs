// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
Console.Write("Введите число элементов массива: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] GetArray(int size)
{
    Random rnd = new Random();
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(99, 1000);
    }
    return array;
}
void QuantityEven(int[] array)
{
    int count=0;
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
        for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 10 % 2 == 0) count++;      
    }
    Console.Write($"->{count}");    
}

int[] array = GetArray(number);
QuantityEven(array);


