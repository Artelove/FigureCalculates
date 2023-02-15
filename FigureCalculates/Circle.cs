namespace FigureCalculates;

public class Circle : Figure
{
    private readonly float _radius;

    public Circle(float radius)
    {
        _radius = radius;
        CheckFigureCorrectness();
    }

    public override float Area => MathF.PI * _radius * _radius;

    protected override void CheckFigureCorrectness()
    {
        if (_radius < 0)
            throw new Exception("Radius cannot have a negative value");
    }
}