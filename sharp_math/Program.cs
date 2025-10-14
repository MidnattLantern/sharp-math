

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
        case "99":
        case "exit":
            isRunning = false;
            break;
        case "1":
        case "assignxcoordinates":
            try
            {
                int inputX1 = Convert.ToInt32(Console.ReadLine());
                int inputX2 = Convert.ToInt32(Console.ReadLine());
                math.assignXCoordinates(inputX1, inputX2);
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }            
            break;
        case "2":
        case "assignycoordinates":
            try
            {
                int inputY1 = Convert.ToInt32(Console.ReadLine());
                int inputY2 = Convert.ToInt32(Console.ReadLine());
                math.assignYCoordinates(inputY1, inputY2);
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
            break;
        case "3":
        case "calculateslope":
            math.calculateSlope();
            break;
        case "4":
        case "revealxcoordinates":
            math.revealXCoordinates();
            break;
        case "5":
        case "revealycoordinates":
            math.revealYCoordinates();
            break;
        default:
            invalidPrompt = prompt;
            break;
    }
}
UI.WriteExit();