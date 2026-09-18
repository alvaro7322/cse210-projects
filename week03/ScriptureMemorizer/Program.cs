using System;
 
class Program
{
    private const int WordsToHidePerRound = 3;
 
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
 
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture = new Scripture(
            reference,
            "Trust in the Lord with all your heart and lean not on your own " +
            "understanding; in all your ways submit to him, and he will make " +
            "your paths straight."
        );
 
        RunMemorizationLoop(scripture);
    }
 
    private static void RunMemorizationLoop(Scripture scripture)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
 
            if (scripture.IsCompletelyHidden())
            {
                break;
            }
 
            Console.WriteLine("Press Enter to continue, or type 'quit' to quit: ");
            string input = Console.ReadLine();
 
            if (input != null && input.ToLower() == "quit")
            {
                break;
            }
 
            scripture.HideRandomWords(WordsToHidePerRound);
        }
    }
}