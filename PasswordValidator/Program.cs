string password = Console.ReadLine();

bool lengthPassword = IsPassLongEnough(password);
bool lettersAndDigits = OnlyLettersAndDigits(password);
bool atLeastTwoDigits = ContainAtLeastTwoDigits(password);

if (lengthPassword == false)
{
    Console.WriteLine("Password must be between 6 and 10 characters");
}
if (lettersAndDigits == false)
{
    Console.WriteLine("Password must consist only of letters and digits");
}
if (atLeastTwoDigits == false)
{
    Console.WriteLine("Password must have at least 2 digits");
}
if (lengthPassword && lettersAndDigits && atLeastTwoDigits)
{
    Console.WriteLine("Password is valid");
}
static bool IsPassLongEnough (string password)
{
    bool result = false;

    if (password.Length >=6 && password.Length <= 10)
    {
        result = true;
    }

    return result;
}

static bool OnlyLettersAndDigits (string password)
{
    bool result = false;

    for (int i = 0; i < password.Length; i++)
    {
        if (Char.IsLetterOrDigit(password[i]) == false)
        {
            return result;
        }
    }

    result = true;
    return result;
}

static bool ContainAtLeastTwoDigits (string password)
{
    bool result = false;
    int countPassDigits = 0;

    for (int i = 0; i < password.Length; i++)
    {
        if (Char.IsDigit(password[i]))
        {
            countPassDigits++;
        }
    }

    if (countPassDigits >= 2)
    {
        result = true;
    }

    return result;
}