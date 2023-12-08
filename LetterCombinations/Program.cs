char startLetter = Convert.ToChar(Console.ReadLine());
char endLetter = Convert.ToChar(Console.ReadLine());
char excludedLetter = Convert.ToChar(Console.ReadLine());

int countOfCombinations = 0;

for (int i = startLetter; i <= endLetter; i++)
{
    char firstLetter = (char)i;
    if (firstLetter == excludedLetter)
    {
        continue;
    }

    for (int j = startLetter; j <= endLetter; j++)
    {
        char secondLetter = (char)j;
        if (j == excludedLetter)
        {
            continue;
        }

        for (int k = startLetter; k <= endLetter; k++)
        {
            char thirdLetter = (char)k;
            if (thirdLetter == excludedLetter)
            {
                continue;
            }

            string letterCombination = firstLetter.ToString() + secondLetter.ToString() + thirdLetter.ToString(); 

            Console.Write(letterCombination + " ");
            countOfCombinations++;
        }
    }
}

Console.WriteLine();
Console.WriteLine(countOfCombinations);