using System;

public class Calculator
{
    public static string f1Path = "./1.txt";
    public static string f2Path = "./2.txt";
    public static string outputPath = "./result.txt";

    public static void Main(string[] args)
    {
        char opr;

        while (true)
        {
            Console.Write("Enter an operator (+, -, /, *): ");
            if (char.TryParse(Console.ReadLine(), out opr) && "/-+*".Contains(opr))
                break;

            Console.WriteLine("Invalid operator.");
        }
        string[] numbers_1 = File.ReadAllLines(f1Path);
        string[] numbers_2 = File.ReadAllLines(f2Path);
        float result = 0.0f, n1, n2;
            using StreamWriter writer = new(outputPath);
            for (int i = 0; i < numbers_1.Length; i++)
            {
                n1 = float.Parse(numbers_1[i]);
                n2 = float.Parse(numbers_2[i]);

                if (opr == '+') result = n1 + n2;
                else if (opr == '-') result = n1 - n2;
                else if (opr == '*') result = n1 * n2;
                else if (opr == '/') {
                    if (n2 != 0) result = n1 / n2;
                    else writer.WriteLine("Cannot divide by zero");
                    }

                writer.WriteLine(result);
            }
            Console.WriteLine($"Results saved in {outputPath}");
    }
}