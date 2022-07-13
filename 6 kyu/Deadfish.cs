/*
Write a simple parser that will parse and run Deadfish.

Deadfish has 4 commands, each 1 character long:

i increments the value (initially 0)
d decrements the value
s squares the value
o outputs the value into the return array
Invalid characters should be ignored.

Deadfish.Parse("iiisdoso") => new int[] {8, 64};
*/

using System.Collections.Generic;

public class Deadfish
{
    public static int[] Parse(string data)
    {
        var results = new List<int>();
        int i = 0;
        foreach (var symbols in data.ToCharArray())
        {
            switch (symbols)
            {
                case 'i': i++; break;
                case 'd': i--; break;
                case 's': i *= i; break;
                case 'o': results.Add(i); break;
            }
        }
        return results.ToArray();
    }
}
