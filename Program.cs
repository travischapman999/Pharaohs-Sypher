
System.Console.WriteLine("automated testing ...");
System.Diagnostics.Debug.Assert(ShiftedCharacter('a') == 'b');
System.Console.WriteLine("tests passed.");

char ShiftedCharacter(char originalCharacter)
{
    return (char)(originalCharacter + 1 > 'z' ? originalCharacter - 25 : originalCharacter + 1);
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
    char originalCharacter = Console.ReadKey(true).KeyChar;
    if (originalCharacter == '`') break;
    Console.Write(ShiftedCharacter((char)originalCharacter));

}