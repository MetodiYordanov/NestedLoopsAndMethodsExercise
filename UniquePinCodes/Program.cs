int max1 = int.Parse(Console.ReadLine());
int max2 = int.Parse(Console.ReadLine());
int max3 = int.Parse(Console.ReadLine());

for (int i = 2; i <= max1; i = i + 2)
{
    for (int j = 2; j <= max2; j++)
    {
        for (int k = 2; k <= max3; k = k + 2)
        {
            if (IsPrime(j))
            {
                Console.WriteLine($"{i}{j}{k}");
            }
        }
    }
}

static bool IsPrime(int number)
{
    if (number <= 1) return false;
    if (number == 2) return true;
    if (number % 2 == 0) return false;

    var boundary = (int)Math.Floor(Math.Sqrt(number));

    for (int i = 3; i <= boundary; i += 2)
        if (number % i == 0)
            return false;

    return true;
}