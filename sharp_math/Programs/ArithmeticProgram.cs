class ArithmeticProgram
{
    ArithmeticApp arithmeticApp = new ArithmeticApp();
    ArithmeticUI arithmeticUI = new ArithmeticUI();
    CoreUI coreUI = new CoreUI();
    string prompt;
    bool isRunning = true;
    string invalidPrompt = "";

    public void RunArithmeticProgram()
    {
        isRunning = true;
        while (isRunning)
        {
            arithmeticUI.WriteArithmeticMenu();
            coreUI.WriteUnknownPrompt(invalidPrompt);
            Console.Write("Prompt: ");
            prompt = Console.ReadLine()?.ToLower().Replace(" ", "") ?? "";
            switch (prompt)
            {
                case "0":
                case "back":
                case "backtomain":
                    isRunning = false;
                    break;
                case "1":
                case "assignvalues":
                    arithmeticApp.AssignValues();
                    break;
                case "2":
                case "revealvalues":
                    arithmeticApp.RevealValues();
                    break;
                case "3":
                case "performaddition":
                    arithmeticApp.PerformAddition();
                    break;
                case "4":
                case "performsubtraction":
                    arithmeticApp.PerformSubtraction();
                    break;
                case "5":
                case "performmultiplication":
                    arithmeticApp.PerformMultiplication();
                    break;
                case "6":
                case "performdivision":
                    arithmeticApp.PerformDivision();
                    break;
                default:
                    invalidPrompt = prompt;
                    break;
            }
        }
    }
}