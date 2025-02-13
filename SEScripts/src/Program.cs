namespace SEScripts;

public static class Program
{
    public static void Main()
    {
        var n1 = double.Parse(Console.ReadLine() ?? "");
        var n2 = double.Parse(Console.ReadLine() ?? "");
        var n3 = double.Parse(Console.ReadLine() ?? "");
        
        Console.WriteLine(n1 + n2 - n3);
    }
}