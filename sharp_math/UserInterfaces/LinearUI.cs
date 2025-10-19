class LinearUI
{
    CoreUI coreUI = new CoreUI();

    public void WriteLinearMenu()
    {
        Console.Clear();
        WriteNavigationBar();
        coreUI.DryHeader("Linear Menu");
        Console.WriteLine($" 0: Back to Main");
        Console.WriteLine($" 1: Assign X Coordinates");
        Console.WriteLine($" 2: Assign Y Coordinates");
        Console.WriteLine($" 3: Assign Point 1");
        Console.WriteLine($" 4: Assign Point 2");
        Console.WriteLine($" 5: Calculate Slope");
        Console.WriteLine($" 6: Reveal X Coordinates");
        Console.WriteLine($" 7: Reveal Y Coordinates");
        Console.WriteLine($" 8: Reveal Point 1");
        Console.WriteLine($" 9: Reveal Point 2");
        coreUI.DryHeader();
    }
    public void WriteUnknownPrompt(string? prompt)
    {
        if (string.IsNullOrEmpty(prompt))
        {
            Console.WriteLine();
            return;
        }
        Console.WriteLine($"'{prompt}' is not a valid prompt");
    }
    public void WriteRevealPoints(string header, string point1Name, string point2Name, int point1Value, int point2Value)
    {
        Console.Clear();
        WriteNavigationBar($"Reveal {header}");
        coreUI.DryHeader(header);
        Console.WriteLine($"{point1Name}: {point1Value}");
        Console.WriteLine($"{point2Name}: {point2Value}");
        coreUI.DryHeader();
        Console.WriteLine();
        Console.WriteLine("Press Enter");
        Console.ReadLine();
    }

    public void WriteSlopeCalculation(int x1, int x2, int y1, int y2, int k)
    {
        int lineExtraWidth = 0;
        int lenX1 = x1.ToString().Length - 1;
        int lenX2 = x2.ToString().Length - 1;
        int lenY1 = y1.ToString().Length - 1;
        int lenY2 = y2.ToString().Length - 1;

        if (lenX1 > lineExtraWidth) { lineExtraWidth = lenX1; }
        if (lenX2 > lineExtraWidth) { lineExtraWidth = lenX2; }
        if (lenY1 > lineExtraWidth) { lineExtraWidth = lenY1; }
        if (lenY2 > lineExtraWidth) { lineExtraWidth = lenY2; }
        Console.Clear();
        WriteNavigationBar("Calculate Slope");
        coreUI.DryHeader("Slope (k)");
        Console.WriteLine();
        Console.WriteLine($"   {y2}{new string(' ', lineExtraWidth - lenY2)} - {y1}{new string(' ', lineExtraWidth - lenY1)}");
        Console.WriteLine($"  -------{new string('-', lineExtraWidth * 2)} = {k}");
        Console.WriteLine($"   {x2}{new string(' ', lineExtraWidth - lenX2)} - {x1}{new string(' ', lineExtraWidth - lenX1)}");
        Console.WriteLine();
        coreUI.DryHeader();
        Console.WriteLine();
        Console.WriteLine("Press Enter");
        Console.ReadLine();
    }

    // private
    private void WriteNavigationBar(string? app = null)
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write(" main > linear");
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