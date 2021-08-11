using System;

public class Class1
{
    public Class1()
    {
        double? x = null;
        double? y = 10;

        double a = x ?? 5;
        double b = y ?? 5;

        Console.WriteLine(a);
        Console.WriteLine(b);

    }
}
