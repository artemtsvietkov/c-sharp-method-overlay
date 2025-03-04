internal class Program
{
    static void Main()
    {
        Console.WriteLine(add(1, 5, 11));     
        Console.WriteLine(add(0.3, 0.365, 0.6435));
        Console.WriteLine(add("C", "#"));
        Console.WriteLine(add("A", "B", "C"));  
    }

    static dynamic add(dynamic a, dynamic b, dynamic c = null)
    {
        if (c != null)
        {
            return a + b + c;
        }
        return a + b;
    }
}
