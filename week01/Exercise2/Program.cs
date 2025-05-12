using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade percentage: ");
        string input = Console.ReadLine();
        int grade = int.Parse(input);

        string letter = "";
        string sign = "";

        // Below is were I will determine the letter grade using the "if" function
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >=80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >=60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // below us where we will have to determine the + or the - sign #This is the block that will add the + or - beside the letter grade
        int lastDigit = grade % 10;
        if (letter != "A" && letter != "F") // the line here is A+ and F+/F- are not valid I also learn that && means True and ! means its a reverse condition where the true can become false and vise versa
        {
            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3) // is gthe last digit here is 0,1 or 2 we will add the "-" sign - look at comment below
            {
                sign = "-"; // here I have left the string empty becasue if the last digit is between 3 to 6 then there is no sign 
            }
        }
        else if (letter == "A" && grade < 93)// here we will have to allow A- only if its between 90 to 92 anything above 93 is an A+ hence the empty string in the next two line
        {
            sign = "-";
        } // For F grades, we do not apply any sign at all (F+, F- as they are invalid)
          // So we do nothing in this case, hence the 'sign' stays empty

        // below will be the final grade output
        Console.WriteLine($"Your grade is:{letter}{sign}");

        // below is the pass or fail message
        if (grade >= 70)
        {
            Console.WriteLine("Congretulations, you have passed the corse");
        }
                else
                {
                    Console.WriteLine("We are sorry. you have failed the course, try again next semester");
                }     
    }
}