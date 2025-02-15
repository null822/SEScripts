namespace SEScripts.scripts;

public class Marks : IScript
{
    public void Run()
    {
        Console.Write("Mark Percentage: ");
        var mark = double.Parse(Console.ReadLine() ?? "");
        
        var offset = Math.Min((uint)((100 - mark) / 10), 5);
        var grade = (char)('A' + offset); // add offset to Unicode 'A' (0x41)
        
        Console.WriteLine($"Grade: {grade}");
    }
}