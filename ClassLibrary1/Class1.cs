using System;

namespace ClassLibrary1;

public static partial class Class1
{
    public static string GetS(string s)
    {
        var x = GetS2(s);

        return x ?? throw new InvalidOperationException();
    }

    private static partial string? GetS2(string s);
}
