int[] Massive()
{   
    Console.WriteLine("Укажите размер массива: ");
    int N = int.Parse(Console.ReadLine());
    int[] array = new int[N];
    for (int i = 0; i < array.Length; i++)
    {
        if (i != array.Length - 1) Console.Write($"{array[i] = new Random().Next(0, 100)}, ");
        else Console.Write($"{array[i] = new Random().Next(0, 100)} ");
    }
    return array;
}

int[] array = Massive();

Console.WriteLine();

string ArrayMaxMin(int[] array)
{   
    int max = 0;
    int min = 100;
    double sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (max < array[i]) 
        {
            max = array[i];
        }
        if (min > array[i])
        { 
            min = array[i];
        }
        sum += array[i];
    }
    
    return $"Разница между максимальным и минимальным числом в массиве = {max - min}";
}


Console.WriteLine(ArrayMaxMin(array));