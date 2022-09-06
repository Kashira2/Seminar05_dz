  void palindrom(int num)
    {
        int num1 = num;
        if (num % 10 == num / 10000)
        {
            if ((num1 % 100)/10 == (num1/1000)%10)
            {
                Console.WriteLine($"Да");
            }
        }
        else
        {
            Console.WriteLine($"Нет");
        }
    }
    
    Console.WriteLine("Введите число");
    int N = int.Parse(Console.ReadLine());
    palindrom(N);

