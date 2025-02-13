namespace SEScripts;

public static class ScriptRegistry
{
    private static readonly Dictionary<string, IScript> Scripts = [];
    
    public static void Register(string name, IScript script)
    {
        Scripts.Add(name, script);
    }

    public static IScript GetScript(string name) => Scripts[name];
    public static bool TryGetScript(string name, out IScript? script) => Scripts.TryGetValue(name, out script);

    public static void RunScript(string name) => Scripts[name].Run();
    public static bool TryRunScript(string name)
    {
        if (!Scripts.TryGetValue(name, out var script)) return false;
        
        script.Run();
        return true;
    }
}