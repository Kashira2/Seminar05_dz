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
    int sum = 0;
    for (int i = 1; i < array.Length; i=i+2)
    {
        sum = array[i] + sum;
    }
    return $"{sum}";
}

Console.WriteLine();
Console.WriteLine($" Сумма чисел на нечетных позициях в массиве = {CountNumber(Massive())}.");