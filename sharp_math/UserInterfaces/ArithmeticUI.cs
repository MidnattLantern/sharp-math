class ArithmeticUI
{
    CoreUI coreUI = new CoreUI();

    public void WriteArithmeticMenu()
    {
        Console.Clear();
        WriteNavigationBar();
        coreUI.DryHeader("Arithmetic Menu");
        Console.WriteLine($" 0: Back to Main");
        Console.WriteLine($" 1: Assign Values");
        Console.WriteLine($" 2: Reveal Values");
        Console.WriteLine($" 3: Perform Addition");
        Console.WriteLine($" 4: Perform Subtraction");
        Console.WriteLine($" 5: Perform Multiplication");
        Console.WriteLine($" 6: Perform Division");
        coreUI.DryHeader();
    }

    public void WriteRevealValues(int value1, int value2)
    {
        Console.Clear();
        WriteNavigationBar("reveal values");
        coreUI.DryHeader("Values");
        Console.WriteLine($"Value 1: {value1}");
        Console.WriteLine($"Value 2: {value2}");
        coreUI.DryHeader();
        Console.WriteLine();
        Console.WriteLine("Press Enter");
        Console.ReadLine();
    }

    public void WritePerformCalculation(string title, string operatior, int value1, int value2, int calculation)
    {
        Console.Clear();
        WriteNavigationBar(title.ToLower());
        coreUI.DryHeader(title);
        Console.WriteLine($"{value1} {operatior} {value2} = {calculation}");
        coreUI.DryHeader();
        Console.WriteLine();
        Console.WriteLine("Press Enter");
        Console.ReadLine();
    }

    // private
    private void WriteNavigationBar(string? app = null)
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write(" main > arithmetic");
        if (string.IsNullOrEmpty(app))
        {
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine($" ({app})");
        }
        Console.ResetColor();
    }
}