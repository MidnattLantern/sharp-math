CoreUI coreUI = new CoreUI();

LinearApp linearMath = new LinearApp();
LinearProgram linearProgram = new LinearProgram();

bool isRunning = true;
string prompt;
string invalidPrompt = "";

while (isRunning)
{
    coreUI.WriteMainMenu();
    coreUI.WriteUnknownPrompt(invalidPrompt);
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
        case "linear":
            linearProgram.RunLinearProgram();
            break;
        default:
            invalidPrompt = prompt;
            break;
        /*
        case "0":
        case "exit":
            isRunning = false;
            break;
        case "1":
        case "assignxcoordinates":
            linearMath.assignXCoordinates();
            break;
        case "2":
        case "assignycoordinates":
            linearMath.assignYCoordinates();
            break;
        case "3":
        case "assignpoint1":
            linearMath.AssignPoint1();
            break;
        case "4":
        case "assignpoint2":
            linearMath.AssignPoint2();
            break;
        case "5":
        case "calculateslope":
            linearMath.calculateSlope();
            break;
        case "6":
        case "revealxcoordinates":
            linearMath.revealXCoordinates();
            break;
        case "7":
        case "revealycoordinates":
            linearMath.revealYCoordinates();
            break;
        default:
            invalidPrompt = prompt;
            break;
        case "8":
        case "revealpoint1":
            linearMath.RevealPoint1();
            break;
        case "9":
        case "revealpoint2":
            linearMath.RevealPoint2();
            break;
        */
    }
}
coreUI.WriteExit();