bool Palindrom(string n)
{
    for (int i = 1; i <= n.Length / 2; i++)
    {
        for (int j = n.Length - 1; j != i; j--)
        {
            if (n[i] != n[n.Length - 1 - i]) return false;
            else return true;
        }
    }
    return true;
}

Console.WriteLine("Введите число ");
string N = Console.ReadLine();

if (Palindrom(N) == true) Console.WriteLine("число является палиндромом ");
else Console.WriteLine("число не является палиндромом ");
