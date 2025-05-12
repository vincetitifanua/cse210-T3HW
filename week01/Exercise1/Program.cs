using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("what is your first name? "); // So in order for you to have the answer written right beside the question, remove "line" from "writeLine" 
        string first = Console.ReadLine();

        Console.Write("What is your Last Name? ");
        String last = Console.ReadLine();

        Console.WriteLine($"Your name is {last} {first} {last}");
    }
}