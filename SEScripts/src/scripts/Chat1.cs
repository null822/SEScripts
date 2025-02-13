namespace SEScripts.scripts;

public class Chat1 : IScript
{
    public void Run()
    {
        var word = Console.ReadLine();
        if (word is null || word.Contains(' '))
        {
            Console.WriteLine("Invalid word supplied");
            return;
        }
        Console.WriteLine($"Hi, did you say {word}?");
    }
}