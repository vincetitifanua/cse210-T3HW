using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        string scriptureText = "Trust in the Lord with all thine heart and lean not unto thine own understanding";

        Scripture scripture = new Scripture(reference, scriptureText);

        while (true)
        {
            Console.Clear();
            scripture.Display();

            if (scripture.IsCompletelyHidden())
                break;

            Console.WriteLine("Press Enter to hide more words or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            scripture.HideRandomWords(3); // You can change the number of words hidden per round
        }

        Console.WriteLine("All words hidden. Program ended.");
    }
}