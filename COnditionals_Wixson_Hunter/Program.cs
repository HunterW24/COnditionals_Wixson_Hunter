using System;

class Program
{
    static void Main(string[] args)
    {
        // Check if a given number is positive or negative and even or odd
        int number = 10; // Change the number here
        Console.WriteLine($"Number: {number}");

        if (number > 0)
        {
            Console.WriteLine("Positive");
        }
        else if (number < 0)
        {
            Console.WriteLine("Negative");
        }
        else
        {
            Console.WriteLine("Zero");
        }

        if (number % 2 == 0)
        {
            Console.WriteLine("Even");
        }
        else
        {
            Console.WriteLine("Odd");
        }

        // Compare three numbers and display the largest one
        int num1 = 25;
        int num2 = 15;
        int num3 = 30;

        int largest = num1;

        if (num2 > largest)
        {
            largest = num2;
        }

        if (num3 > largest)
        {
            largest = num3;
        }

        Console.WriteLine($"Largest number: {largest}");

        // Switch statement to display equivalent description for a grade
        char grade = 'B'; // Change the grade here
        Console.Write("Grade: " + grade + " - ");

        switch (grade)
        {
            case 'A':
                Console.WriteLine("Superior");
                break;
            case 'B':
                Console.WriteLine("Very Good");
                break;
            case 'C':
                Console.WriteLine("Average");
                break;
            case 'D':
                Console.WriteLine("Below Average");
                break;
            case 'F':
                Console.WriteLine("Fail");
                break;
            default:
                Console.WriteLine("Invalid Grade");
                break;
        }
    }
}