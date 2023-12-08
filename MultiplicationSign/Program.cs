int firstNumber = int.Parse(Console.ReadLine());
int secondNumber = int.Parse(Console.ReadLine());
int thirdNumber = int.Parse(Console.ReadLine());

string output = ProductOfNumbers(firstNumber, secondNumber, thirdNumber);

Console.WriteLine(output);

static string ProductOfNumbers (int firstNumber, int secondNumber, int thirdNumber)
{
    string result = "positive";
    int countNegativeNumbers = 0;

    if (firstNumber == 0 || secondNumber == 0 || thirdNumber == 0)
    {
        result = "zero";
        return result;
    }
    if (firstNumber < 0)
    {
        countNegativeNumbers++;
    }
    if (secondNumber < 0) 
    { 
        countNegativeNumbers++;
    }
    if (thirdNumber < 0)
    {
        countNegativeNumbers++;
    }
    if (countNegativeNumbers == 1 || countNegativeNumbers == 3)
    {
        result = "negative";
    }

    return result;
}