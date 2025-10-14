class MathApp
{
    UIApp UI = new UIApp();
    protected int x1;
    protected int x2;
    protected int y1;
    protected int y2;
    protected int deltaX;
    protected int deltaY;
    protected int slopeK;

    public void assignXCoordinates(int assignX1, int assignX2)
    {
        try
        {
            x1 = assignX1;
            x2 = assignX2;
            deltaX = assignX2 - assignX1;
            UI.WriteUserFeedback("Delta X", $"Delta X is: {deltaX}");
        }
        catch (Exception err)
        {
            Console.WriteLine($"assignXCoordinates error: {err.Message}");
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

    public void assignYCoordinates(int assignY1, int assignY2)
    {
        try
        {
            y1 = assignY1;
            y2 = assignY2;
            deltaY = assignY2 - assignY1;
            UI.WriteUserFeedback("Delta Y", $"Delta Y is: {deltaY}");
        }
        catch (Exception err)
        {
            Console.WriteLine($"assignYCoordinates error: {err.Message}");
        }

    }

    public void calculateSlope()
    {
        try
        {
            slopeK = deltaY / deltaX;
            UI.WriteUserFeedback("Slope", $"Slope (k) value is: {slopeK}");
        }
        catch (Exception err)
        {
            Console.WriteLine(err.Message);
        }
    }
}