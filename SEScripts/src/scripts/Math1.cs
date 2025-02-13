namespace SEScripts.scripts;

public class Math1 : IScript
{
    public void Run()
    {
        var n1 = double.Parse(Console.ReadLine() ?? "");
        var n2 = double.Parse(Console.ReadLine() ?? "");
        var n3 = double.Parse(Console.ReadLine() ?? "");
        
        Console.WriteLine(n1 + n2 - n3);
    }
}