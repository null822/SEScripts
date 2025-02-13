using SEScripts.scripts;

namespace SEScripts;

public static class Program
{
    public static void Main()
    {
        ScriptRegistry.Register("math1", new Math1());
        ScriptRegistry.Register("chat1", new Chat1());
        
        Console.Write("Script to run: ");
        var scriptName = Console.ReadLine() ?? "";
        var success = ScriptRegistry.TryRunScript(scriptName);
        if (!success) Console.WriteLine($"Script {scriptName} was not found");

    }
}