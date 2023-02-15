namespace FigureCalculates;

public class Triangle : Figure
{
    private readonly float _sideA;
    private readonly float _sideB;
    private readonly float _sideC;

    public Triangle(float a, float b, float c)
    {
        _sideA = a;
        _sideB = b;
        _sideC = c;
        CheckFigureCorrectness();
    }

    protected override void CheckFigureCorrectness()
    {
        if (_sideA < 0 || _sideB < 0 || _sideC < 0)
            throw new Exception("The sides cannot have a negative value");
        if (_sideA + _sideB < _sideC ||
            _sideA + _sideC < _sideB ||
            _sideC + _sideB < _sideA)
            throw new Exception("The condition is not fulfilled:" +
                                " a triangle exists when the sum of any two of its sides is greater than the third side.");
    }

    private float Perimeter => _sideA + _sideB + _sideC;
    private float HalfPerimeter => Perimeter / 2;

    public override float Area => (float)Math.Sqrt(HalfPerimeter * 
                                                   (HalfPerimeter - _sideA) * 
                                                   (HalfPerimeter - _sideB) *
                                                   (HalfPerimeter - _sideC));

    public bool IsRightTriangle
    {
        get
        {
            float pow2SideA = _sideA * _sideA; 
            float pow2SideB = _sideB * _sideB; 
            float pow2SideC = _sideC * _sideC;
            return Math.Abs(pow2SideA + pow2SideB - pow2SideC) < ACCURACY ||
                   Math.Abs(pow2SideB + pow2SideC - pow2SideA) < ACCURACY ||
                   Math.Abs(pow2SideC + pow2SideA - pow2SideB) < ACCURACY;
        }
    }
}