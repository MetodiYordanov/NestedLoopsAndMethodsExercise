int number = int.Parse(Console.ReadLine());

for (int firstDigit = 1; firstDigit <= number; firstDigit++)
{
    for (int secondDigit = 0; secondDigit <= number; secondDigit++)
    {
        for (int thirdDigit = 0; thirdDigit <= number; thirdDigit++)
        {
            for (int fourthDigit = 0; fourthDigit <= number; fourthDigit++)
            {
                if (firstDigit + secondDigit == thirdDigit + fourthDigit && firstDigit + secondDigit == number)
                {
                    string numberToPrint = firstDigit.ToString() + secondDigit.ToString() + thirdDigit.ToString() + fourthDigit.ToString();
                    Console.Write(numberToPrint + " ");
                }
            }
        }
    }
}