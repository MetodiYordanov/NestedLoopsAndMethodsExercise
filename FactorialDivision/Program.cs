int firstNumber = int.Parse(Console.ReadLine());
int secondNumber = int.Parse(Console.ReadLine());

int factorialFirstNum = Factorial(firstNumber);
int factorialSecondNum = Factorial(secondNumber);

double result = (double)factorialFirstNum / factorialSecondNum;

Console.WriteLine(result);

static int Factorial (int number)
{
    int output = number;

    if (output == 1 || output == 0)
    {
        return output;
    }
    else
    {
        for (int i = number - 1; i >= 1; i--)
        {
            output = output * i;
        }
    }

    return output;
}