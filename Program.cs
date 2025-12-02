RunTests();
RunMain();

static char ShiftedCharacter(char originalCharacter, int keyShift = 1)
{
    if (originalCharacter + keyShift > 'z')
    {
        return AsChar(originalCharacter + (keyShift - 26));
    }
    else if (originalCharacter + keyShift < 'a')
    {
        return AsChar(originalCharacter + (keyShift + 26));
    }
    else return AsChar(originalCharacter + keyShift);
}

static char AsChar(int asciiValue)
{
    return (char)asciiValue;
}

static void RunMain()
{
    int keyShift = 1;
    while (true)
    {
        ConsoleKeyInfo Input = Console.ReadKey(true);
        ConsoleKey InputKey = Input.Key;
        char originalCharacter = Input.KeyChar;
        if (InputKey == ConsoleKey.Escape) break;
        else if (InputKey == ConsoleKey.UpArrow) keyShift++;
        else if (InputKey == ConsoleKey.DownArrow) keyShift--;
        else if (InputKey == ConsoleKey.Spacebar) Console.Write(' ');
        else Console.Write(ShiftedCharacter(originalCharacter, keyShift));
    }
}

static void RunTests()
{
    System.Console.WriteLine("automated testing ...");
    System.Diagnostics.Debug.Assert(ShiftedCharacter('a') == 'b');
    System.Diagnostics.Debug.Assert(ShiftedCharacter('a') == 'b');
    System.Diagnostics.Debug.Assert(AsChar('a' + 0) == 'a');
    System.Diagnostics.Debug.Assert(AsChar('a' + 1) == 'b');
    System.Diagnostics.Debug.Assert(AsChar('a' + 3) == 'd');
    System.Console.WriteLine("tests passed.");
    System.Console.WriteLine();
}