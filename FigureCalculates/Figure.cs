namespace FigureCalculates;

public abstract class Figure
{
    public const float ACCURACY = 0.000001f;
    public abstract float Area { get; }

    protected abstract void CheckFigureCorrectness();
}