int number = int.Parse(Console.ReadLine());

for (int i = 100; i <= 999; i++)
{
    int firstDigit = 0;
    int secondDigit = 0;
    int thirdDigit = 0;

    string currentNumToString = i.ToString();

    for (int j = 0; j < 3; j++)
    {
        if (j == 0)
        {
            firstDigit = int.Parse(currentNumToString[j].ToString());
        }
        else if (j == 1)
        {
            secondDigit = int.Parse(currentNumToString[j].ToString());
        }
        else
        {
            thirdDigit = int.Parse(currentNumToString[j].ToString());
        }
    }

    int product = firstDigit * secondDigit * thirdDigit;

    if (product == number)
    {
        Console.Write(i + " ");
    }
}