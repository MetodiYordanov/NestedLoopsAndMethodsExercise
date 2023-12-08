string word = Console.ReadLine();

int result = VowelsCount(word);

Console.WriteLine(result);

static int VowelsCount(string word)
{
    int vowels = 0;
    for (int i = 0; i < word.Length; i++)
    {
        char letter = Char.ToLower(word[i]);
        
        switch (letter)
        {
            case 'a':
            case 'i':
            case 'o':
            case 'u':
            case 'e':
                vowels++;
                break;
        }
    }

    return vowels;
}