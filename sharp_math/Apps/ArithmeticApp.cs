class ArithmeticApp
{
    ArithmeticUI arithmeticUI = new ArithmeticUI();
    CoreUI coreUI = new CoreUI();

    protected int value1 = 0;
    protected int value2 = 0;

    public void AssignValues()
    {
        try
        {
            coreUI.WriteAssignInput("Value 1", "Assign Values", true);
            value1 = Convert.ToInt32(Console.ReadLine());
            coreUI.WriteAssignInput("Value 2", "Assign Values");
            value2 = Convert.ToInt32(Console.ReadLine());
        }
        catch (Exception err)
        {
            coreUI.WriteError(err.Message);
        }
    }

    public void RevealValues()
    {
        try
        {
            arithmeticUI.WriteRevealValues(value1, value2);
        }
        catch (Exception err)
        {
            coreUI.WriteError(err.Message);
        }
    }

    public void PerformAddition()
    {
        try
        {
            arithmeticUI.WritePerformCalculation("Addition", "+", value1, value2, value1+value2);
        }
        catch (Exception err)
        {
            coreUI.WriteError(err.Message);
        }
    }

    public void PerformSubtraction()
    {
        try
        {
            arithmeticUI.WritePerformCalculation("Subtraction", "-", value1, value2, value1-value2);
        }
        catch (Exception err)
        {
            coreUI.WriteError(err.Message);
        }
    }

    public void PerformMultiplication()
    {
        try
        {
            arithmeticUI.WritePerformCalculation("Multiplication", "*", value1, value2, value1*value2);
        }
        catch (Exception err)
        {
            coreUI.WriteError(err.Message);
        }
    }

    public void PerformDivision()
    {
        try
        {
            arithmeticUI.WritePerformCalculation("Division", "/", value1, value2, value1/value2);
        }
        catch (Exception err)
        {
            coreUI.WriteError(err.Message);
        }
    }
}