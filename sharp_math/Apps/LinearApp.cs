class LinearApp
{
    CoreUI coreUI = new CoreUI();
    LinearUI linearUI = new LinearUI();

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
            coreUI.WriteAssignInput("X1", "Assign X", true);
            x1 = Convert.ToInt32(Console.ReadLine());
            coreUI.WriteAssignInput("X2");
            x2 = Convert.ToInt32(Console.ReadLine());
            deltaX = x2 - x1;
            coreUI.WriteUserFeedback("Delta X", $"Delta X is: {deltaX}");
        }
        catch (Exception err)
        {
            coreUI.WriteError(err.Message);
        }
    }

    public void assignYCoordinates()
    {
        try
        {
            coreUI.WriteAssignInput("Y1", "Assign Y", true);
            y1 = Convert.ToInt32(Console.ReadLine());
            coreUI.WriteAssignInput("Y2");
            y2 = Convert.ToInt32(Console.ReadLine());
            deltaY = y1 - y2;
            coreUI.WriteUserFeedback("Delta Y", $"Delta Y is: {deltaY}");
        }
        catch (Exception err)
        {
            coreUI.WriteError(err.Message);
        }
    }

    public void AssignPoint1() // use PascalCase for methods
    {
        try
        {
            coreUI.WriteAssignInput("X", "Assign Point 1", true);
            x1 = Convert.ToInt32(Console.ReadLine());
            coreUI.WriteAssignInput("Y");
            y1 = Convert.ToInt32(Console.ReadLine());
            deltaX = x2 - x1;
            deltaY = y2 - y1;
        }
        catch (Exception err)
        {
            coreUI.WriteError(err.Message);
        }
    }

    public void AssignPoint2()
    {
        try
        {
            coreUI.WriteAssignInput("X", "Assign Point 2", true);
            x2 = Convert.ToInt32(Console.ReadLine());
            coreUI.WriteAssignInput("Y");
            y2 = Convert.ToInt32(Console.ReadLine());
            deltaX = x2 - x1;
            deltaY = y2 - y1;
        }
        catch (Exception err)
        {
            coreUI.WriteError(err.Message);
        }
    }

    public void revealXCoordinates()
    {
        linearUI.WriteRevealPoints("X coordinates", "X1", "X2", x1, x2);
    }

    public void revealYCoordinates()
    {
        linearUI.WriteRevealPoints("Y coordinates", "Y1", "Y2", y1, y2);
    }

    public void RevealPoint1()
    {
        linearUI.WriteRevealPoints("Point 1", "X", "Y", x1, y1);
    }
    
    public void RevealPoint2()
    {
        linearUI.WriteRevealPoints("Point 2", "X", "Y", x2, y2);
    }

    public void calculateSlope()
    {
        try
        {
            slopeK = deltaY / deltaX;
            linearUI.WriteSlopeCalculation( x1, x2, y1, y2, slopeK );
        }
        catch (Exception err)
        {
            coreUI.WriteError(err.Message);
        }
    }
}