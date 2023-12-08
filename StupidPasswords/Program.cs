int number = int.Parse(Console.ReadLine());

for (int i = 2; i <= number; i = i + 2)
{
	for (int j = 1; j <= number; j = j + 2)
	{
        int product = i * j;
        string passwordToString = i.ToString() + j.ToString() + product.ToString();
        Console.Write(passwordToString + " ");
    }
}