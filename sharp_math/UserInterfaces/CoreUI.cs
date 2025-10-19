class CoreUI
{
    public void WriteMainMenu() // "method"
    {
        Console.Clear();
        DryHeader("Main Menu");
        Console.WriteLine($" 0: Exit");
        Console.WriteLine($" 1: Assign X Coordinates");
        Console.WriteLine($" 2: Assign Y Coordinates");
        Console.WriteLine($" 3: Assign Point 1");
        Console.WriteLine($" 4: Assign Point 2");
        Console.WriteLine($" 5: Calculate Slope");
        Console.WriteLine($" 6: Reveal X Coordinates");
        Console.WriteLine($" 7: Reveal Y Coordinates");
        Console.WriteLine($" 8: Reveal Point 1");
        Console.WriteLine($" 9: Reveal Point 2");
        DryHeader();
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

    public void WriteError(string message)
    {
        Console.Clear();
        DryHeader("Error");
        Console.WriteLine(message);
        Console.WriteLine("Press Enter");
        Console.ReadLine();
    }

    public void WriteAssignInput(string prompt, string header = "", bool useHeader = false)
    {
        if (useHeader)
        {
            Console.Clear();
            DryHeader(header);
        }
        Console.Write($"{prompt}: ");
    }

    public void WriteUserFeedback(string header, string message)
    {
        Console.Clear();
        DryHeader(header);
        Console.WriteLine(message);
        DryHeader();
        Console.WriteLine();
        Console.WriteLine("Press Enter");
        Console.ReadLine();
        // redirect home
    }

    public void WriteExit()
    {
        Console.Clear();
        Console.WriteLine("Exit");
    }

    const int ViewportWidth = 24;
    public void DryHeader(string? name = null)
    {
        if (string.IsNullOrEmpty(name))
        {
            Console.WriteLine(new string('-', ViewportWidth));
            return;
        }

        int fullBorderLength;
        float leftBorderLength;
        float rightBorderLength;

        fullBorderLength = ViewportWidth - name.Length - 2;
        leftBorderLength = fullBorderLength / 2f;
        rightBorderLength = fullBorderLength / 2f;

        // handle uneven width
        if (fullBorderLength % 2 == 1)
        {
            leftBorderLength += 0.5f;
            rightBorderLength -= 0.5f;
        }

        // render header
        Console.Write(new string('-', (int)leftBorderLength));
        Console.Write($" {name} ");
        Console.WriteLine(new string('-', (int)rightBorderLength));
    }
}