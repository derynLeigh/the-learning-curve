using System;

public class Calculator
{
    // Modify these paths if needed
    // These terms are set to 'public' and 'static' to make them accessible for the Unit Tests
    public static string f1Path = "C:\\Users\\Public\\Documents\\1.txt";
    public static string f2Path = "C:\\Users\\Public\\Documents\\2.txt";
    public static string outputPath = "C:\\Users\\Public\\Documents\\result.txt";

    public static void Main(string[] args)
    {
        char opr;

        while (true)
        {
            Console.Write("Enter an operator (+, -, /, *): ");

            // Simplified code using TryParse
            if (char.TryParse(Console.ReadLine(), out opr) && "/-+*".Contains(opr))
                break;

            Console.WriteLine("Invalid operator.");
        }

        // Write code below this line

        // Write code above this line
    }
}