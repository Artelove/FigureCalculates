namespace FigureCalculates;

public class Rectangle : Figure
{
    protected readonly float SideA;
    protected readonly float SideB;

    public Rectangle(float sideA, float sideB)
    {
        SideA = sideA;
        SideB = sideB;
        CheckFigureCorrectness();
    }

    public override float Area => SideA * SideB;
    
    protected override void CheckFigureCorrectness()
    {
        if (SideA < 0 || SideB < 0)
            throw new Exception("The sides cannot have a negative value");

    }
}