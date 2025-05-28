using System

internal class Program
{
    static int add(int x, int y)
    {
        return x + y;
    }

    static double add(double x, double y)
    {
        return x + y;
    }

    static string add(string x, string y)
    {
        return x + y;
    }

    static string add(char x, char y)
    {
        return x.ToString() + y.ToString();
    }

    static void Main(string[] args)
    {
        AddV();
    }

    static void AddV()
    {
        Console.WriteLine(add(10, 25));
        Console.WriteLine(add(3.14, 2.7421));
        Console.WriteLine(add("sun", "shine"));
        Console.WriteLine(add('N', 'D'));
    }
}
