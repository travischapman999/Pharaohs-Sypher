int keyShift = 1;
System.Console.WriteLine("automated testing ...");
System.Diagnostics.Debug.Assert(ShiftedCharacter('a') == 'b');
System.Console.WriteLine("tests passed.");

char ShiftedCharacter(char originalCharacter)
{
    if (originalCharacter + keyShift > 'z')
    {
        return (char)(originalCharacter + (keyShift - 26));
    }
    else if (originalCharacter + keyShift < 'a')
    {
        return (char)(originalCharacter + (keyShift + 26));
    }
    else return (char)(originalCharacter + keyShift);
}
System.Diagnostics.Debug.Assert(ShiftedCharacter('a') == 'b');
System.Console.WriteLine();
System.Diagnostics.Debug.Assert(AsChar('a' + 0) == 'a');
System.Diagnostics.Debug.Assert(AsChar('a' + 1) == 'b');
System.Diagnostics.Debug.Assert(AsChar('a' + 3) == 'd');

char AsChar(int asciiValue)
{
    return (char)asciiValue;
}

while (true)
{
    ConsoleKeyInfo Input = Console.ReadKey(true);
    ConsoleKey InputKey = Input.Key;
    char originalCharacter = Input.KeyChar;
    if (originalCharacter == '`') break;
    if (InputKey == ConsoleKey.UpArrow) keyShift++;
    if (InputKey == ConsoleKey.DownArrow) keyShift--;
    if (originalCharacter == ' ') Console.Write(' ');
    if (InputKey != ConsoleKey.UpArrow && InputKey!= ConsoleKey.DownArrow && originalCharacter != ' ')
    {
        Console.Write(ShiftedCharacter(originalCharacter));
    }

}