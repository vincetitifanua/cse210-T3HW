// Program.cs
// Main driver file for the Journal application.
// I have completed the core requirements for this assignment.
// Features: Menu, prompt generation, saving/loading, displaying entries.
using System;

class Program
{
    static void Main(string[] args)
    {
       Journal journal = new Journal();
        PromptGenerator promptGen = new PromptGenerator();

        while(true)
        {
            Console.WriteLine("Journal Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Quit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            if(choice == "1")
            {
                string prompt = promptGen.GetRandomPrompt();
                Console.WriteLine($"Prompt: {prompt}");
                Console.Write("Your response: ");
                string response = Console.ReadLine();
                string date = DateTime.Now.ToShortDateString();
                Entry newEntry = new Entry(prompt, response, date);
                journal.AddEntry(newEntry);
                Console.WriteLine("Entry added!\n");
            }
            else if(choice == "2")
            {
                journal.DisplayEntries();
            }
            else if(choice == "3")
            {
                Console.Write("Enter filename to save to: ");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
                Console.WriteLine("Journal saved.\n");
            }
            else if(choice == "4")
            {
                Console.Write("Enter filename to load from: ");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);
                Console.WriteLine("Journal loaded.\n");
            }
            else if(choice == "5")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid option. Try again.");
            }
        }
    }
}