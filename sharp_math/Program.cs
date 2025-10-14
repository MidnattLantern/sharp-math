UIApp UI = new UIApp();
MathApp math = new MathApp();

bool isRunning = true;
string prompt;
string invalidPrompt = "";

while (isRunning)
{
    UI.WriteMainMenu();
    UI.WriteUnknownPrompt(invalidPrompt);
    Console.Write("Prompt: ");
    prompt = Console.ReadLine()?.ToLower().Replace(" ", "") ?? "";
    invalidPrompt = "";
    switch (prompt)
    {
        case "0":
        case "exit":
            isRunning = false;
            break;
        case "1":
        case "assignxcoordinates":
            math.assignXCoordinates();
            break;
        case "2":
        case "assignycoordinates":
            math.assignYCoordinates();
            break;
        case "3":
        case "assignpoint1":
            math.AssignPoint1();
            break;
        case "4":
        case "assignpoint2":
            math.AssignPoint2();
            break;
        case "5":
        case "calculateslope":
            math.calculateSlope();
            break;
        case "6":
        case "revealxcoordinates":
            math.revealXCoordinates();
            break;
        case "7":
        case "revealycoordinates":
            math.revealYCoordinates();
            break;
        default:
            invalidPrompt = prompt;
            break;
    }
}
UI.WriteExit();