class Program
{
    static void Main()
    {                
        Console.WriteLine(Add(1, 2, 4));              
        Console.WriteLine(Add(0.3, 0.2, 0.24534));      
        Console.WriteLine(Add("text", "txet"));     
        Console.WriteLine(Add('A', 'D', 'D'));        
    }

    static dynamic Add(dynamic a, dynamic b)
    {
        return a + b;
    }

    static dynamic Add(dynamic a, dynamic b, dynamic c)
    {
        return a + b + c;
    }
}
