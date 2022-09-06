
int[] Massive()
{   
    Console.WriteLine("Укажите размер массива: ");
    int N = int.Parse(Console.ReadLine());
    int[] array = new int[N];
    for (int i = 0; i < array.Length; i++)
    {
        if (i != array.Length - 1) Console.Write($"{array[i] = new Random().Next(0, 999)}, ");
        else Console.Write($"{array[i] = new Random().Next(0, 999)}.");
    }
    return array;
}

string CountNumber(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0 ) count+= 1;
    }
    return $"{count}";
}

Console.WriteLine();
Console.WriteLine($" Колличество четных чисел в массиве = {CountNumber(Massive())}.");