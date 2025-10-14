class MathApp
{
    UIApp UI = new UIApp();

    protected int x1 = 0;
    protected int x2 = 0;
    protected int y1 = 0;
    protected int y2 = 0;
    protected int deltaX = 0;
    protected int deltaY = 0;
    protected int slopeK = 0;

    public void assignXCoordinates()
    {
        try
        {
            UI.WriteAssignInput("X1", "Assign X", true);
            x1 = Convert.ToInt32(Console.ReadLine());
            UI.WriteAssignInput("X2");
            x2 = Convert.ToInt32(Console.ReadLine());
            deltaX = x2 - x1;
            UI.WriteUserFeedback("Delta X", $"Delta X is: {deltaX}");
        }
        catch (Exception err)
        {
            UI.WriteError(err.Message);
        }
    }

    public void assignYCoordinates()
    {
        try
        {
            UI.WriteAssignInput("Y1", "Assign Y", true);
            y1 = Convert.ToInt32(Console.ReadLine());
            UI.WriteAssignInput("Y2");
            y2 = Convert.ToInt32(Console.ReadLine());
            deltaY = y1 - y2;
            UI.WriteUserFeedback("Delta Y", $"Delta Y is: {deltaY}");
        }
        catch (Exception err)
        {
            UI.WriteError(err.Message);
        }
    }

    public void AssignPoint1() // use PascalCase for methods
    {
        try
        {
            UI.WriteAssignInput("X", "Assign Point 1", true);
            x1 = Convert.ToInt32(Console.ReadLine());
            UI.WriteAssignInput("Y");
            y1 = Convert.ToInt32(Console.ReadLine());
            deltaX = x2 - x1;
            deltaY = y2 - y1;
        }
        catch (Exception err)
        {
            UI.WriteError(err.Message);
        }
    }

    public void AssignPoint2()
    {
        try
        {
            UI.WriteAssignInput("X", "Assign Point 2", true);
            x2 = Convert.ToInt32(Console.ReadLine());
            UI.WriteAssignInput("Y");
            y2 = Convert.ToInt32(Console.ReadLine());
            deltaX = x2 - x1;
            deltaY = y2 - y1;
        }
        catch (Exception err)
        {
            UI.WriteError(err.Message);
        }
    }

    public void revealXCoordinates()
    {
        UI.WriteUserFeedback("Delta X", $"Delta X is: {deltaX}");
    }

    public void revealYCoordinates()
    {
        UI.WriteUserFeedback("Delta Y", $"Delta Y is: {deltaY}");
    }

    public void calculateSlope()
    {
        try
        {
            slopeK = deltaY / deltaX;
            UI.WriteSlopeCalculation( x1, x2, y1, y2, slopeK );
        }
        catch (Exception err)
        {
            UI.WriteError(err.Message);
        }
    }
}