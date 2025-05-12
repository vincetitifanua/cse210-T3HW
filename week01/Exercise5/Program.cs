using System;

class Program
{
    static void Main(string[] args)
    {
                DisplayWelcome();

        // Below is where we will ask the user for their name and save it
        string userName = PromptUserName();

        // Ask the user for their favorite number and also save it
        int favoriteNumber = PromptUserNumber();

        // Here we will have to call the function to square the number
        int squaredNumber = SquareNumber(favoriteNumber);

        // Showing the final message with the result
        DisplayResult(userName, squaredNumber);
    }

    // This function bwlow is to just prints a welcome message
    static void DisplayWelcome()
    {
        Console.WriteLine("Below and Welcome to the program!"); // I am using writeline here instead of just write "Bula" means hellow in Fijian
    }

    // This function asks for the user's name and returns it
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    // This function asks for a number, checks if it's valid,
    // and keeps asking until the user types a real number
    static int PromptUserNumber()
    {
        int number;
        Console.Write("Please enter your favorite number: ");
        string input = Console.ReadLine();

        // Keep asking until the input is a valid number
        while (!int.TryParse(input, out number))
        {
            Console.Write("That wasn't a valid number. Please enter a whole number: ");
            input = Console.ReadLine();
        }

        return number;
    }

    // here the function squares the number and gives it back
    static int SquareNumber(int number)
    {
        return number * number;
    }

    // below function shows the final message using the name and result
    static void DisplayResult(string name, int squared)
    {
        Console.WriteLine($"{name}, the square of your number is {squared}");
    }
}