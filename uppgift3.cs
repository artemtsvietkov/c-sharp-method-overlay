using System;

class Program
{
    static void Main()
    {
        Console.WriteLine(Add(1, 2, 4));                 
        Console.WriteLine(Add(0.3, 0.2, 0.24534));       
        Console.WriteLine(Add("text", "txet"));           
        Console.WriteLine(Add('A', 'D', 'D'));             
    }

    static dynamic Add(params dynamic[] args)
    {
        bool anyStringOrChar = false;
        foreach (var arg in args)
        {
            if (arg is string || arg is char)
            {
                anyStringOrChar = true;
                break;
            }
        }

        if (anyStringOrChar)
        {
            string result = "";
            foreach (var arg in args)
                result += arg.ToString();
            return result;
        }
        else
        {
            dynamic sum = 0;
            foreach (var arg in args)
                sum += arg;
            return sum;
        }
    }
}
