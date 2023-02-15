namespace FigureCalculates;

public class Square : Rectangle
{
    public Square(float side) : base(side, side)
    {
    }

    public override float Area => SideA * SideA;
}