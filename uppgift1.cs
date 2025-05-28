internal class Program
{
    static int AbsV(int x)
    {
        return x < 0 ? -x : x;
    }

    static double AbsV(double x)
    {
        return x < 0 ? -x : x;
    }

    static void Main(string[] args)
    {
        RunAbsV();
    }

    static void RunAbsV()
    {
        Console.WriteLine($"Abs of -42 is {AbsV(42)}");
        Console.WriteLine($"Abs of -9.81 is {AbsV(-9.81)}");
    }
}
