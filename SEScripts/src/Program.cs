using System.Text;
using SEScripts.scripts;

namespace SEScripts;

public static class Program
{
    public static void Main()
    {
        RegisterScripts();
        
        Console.WriteLine("Select a script to run:");
        
        var scriptName = RunSelectorUi();
        
        var success = ScriptRegistry.TryRunScript(scriptName);
        if (!success)
            Console.WriteLine($"Script {scriptName} was not found");
    }
    
    private static void RegisterScripts()
    {
        ScriptRegistry.Register("math1", new Math1());
        ScriptRegistry.Register("chat1", new Chat1());
        ScriptRegistry.Register("marks", new Marks());
        
    }

    private static string RunSelectorUi()
    {
        var scripts = ScriptRegistry.GetNames();

        const int viewportHeight = 5;
        const int viewportStart = 2;
        const int marginWidth = 4;
        
        var scriptCount = scripts.Length;
        var viewportWidth = marginWidth + scripts.Select(s => s.Length).Max() + 1;
        var selectorIndex = 0;
        var viewportTop = 0;
        
        while (true)
        {
            // display the viewport
            
            Console.CursorTop = viewportStart - 1;
            Console.WriteLine($"+{"".PadRight(viewportWidth, '-')}+"); // box top
            for (var i = 0; i < viewportHeight; i++)
            {
                var scriptIndex = viewportTop + i;
                var script = scriptIndex < scripts.Length ? scripts[scriptIndex] : "";
                
                var str = new StringBuilder($"|{"",-(marginWidth-1)}{script}");
                var padLength = Console.WindowWidth - str.Length;
                str = str.Append("".PadRight(padLength)); // right padding to overwrite remaining characters when scrolling
                str[viewportWidth + 1] = '|';
                Console.WriteLine(str);
            }
            // selector character
            Console.SetCursorPosition(marginWidth - 2, viewportStart + selectorIndex - viewportTop);
            Console.WriteLine('>');
            // move mouse to end
            Console.SetCursorPosition(0, viewportStart + viewportHeight);
            Console.WriteLine($"+{"".PadRight(viewportWidth, '-')}+"); // box bottom
            
            // handle navigation input
            
            var input = Console.ReadKey();
            var exit = false;
            var noInput = false;
            switch (input.Key)
            {
                case ConsoleKey.Enter:
                {
                    exit = true;
                    break;
                }
                case ConsoleKey.UpArrow:
                {
                    if (selectorIndex > 0)
                        selectorIndex--;
                    break;
                }
                case ConsoleKey.DownArrow:
                {
                    if (selectorIndex < scriptCount - 1)
                        selectorIndex++;
                    break;
                }
                default:
                {
                    noInput = true;
                    break;
                }
            }

            Console.CursorLeft = 0;
            Console.WriteLine(' ');
            
            if (exit) break;
            if (noInput) continue;
            
            if (selectorIndex > viewportTop + viewportHeight-1)
            {
                viewportTop = Math.Min(scriptCount - viewportHeight, selectorIndex - viewportHeight + 1);
            }
            if (selectorIndex < viewportTop)
            {
                viewportTop = selectorIndex;
            }
            
        }
        Console.Clear();
        
        return scripts[selectorIndex];
    }
}