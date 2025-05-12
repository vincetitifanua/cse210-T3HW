using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number;

        // in the below block we are going to collect numbers from the user
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        do
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());

            // Here we are only going to add the number to the list if it's not 0
            if (number != 0)
            {
                numbers.Add(number);
            }
        }
        while (number != 0);

        // core requirements
        if (numbers.Count > 0)
        {
            // this is the sum of the numbers
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            Console.WriteLine($"The sum is: {sum}");

            // Below blockis the verage of the numbers
            double average = sum / (double)numbers.Count;
            Console.WriteLine($"The average is: {average}");

            // maximum number in the below block
            int maxNumber = numbers[0];
            foreach (int num in numbers)
            {
                if (num > maxNumber)
                {
                    maxNumber = num;
                }
            }
            Console.WriteLine($"The largest number is: {maxNumber}");

            // below is the stretch Challenge
            // in the provided challenge we will find the smallest positive number
            int smallestPositive = int.MaxValue;
            foreach (int num in numbers)
            {
                if (num > 0 && num < smallestPositive)
                {
                    smallestPositive = num;
                }
            }
            if (smallestPositive == int.MaxValue)
            {
                Console.WriteLine("No positive number found.");
            }
            else
            {
                Console.WriteLine($"The smallest positive number is: {smallestPositive}");
            }

            // sorting the list
            numbers.Sort();
            Console.WriteLine("The sorted list is:");
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }
        }
        else
        {
            Console.WriteLine("No numbers were entered.");
        }
    }
}