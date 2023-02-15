namespace FigureCalculates.Tests;

public class CircleTests
{
    [Test]
    public void Circle_Area_ValidRadius_Success()
    {
        //Given
        Circle circle = new Circle(5.3f);
        //When
        float radius = 5.3f;
        float area = (float)Math.PI * radius * radius; 
        //Then
        Assert.That(area, Is.EqualTo(circle.Area).Within(Figure.ACCURACY));
    }
    [Test]
    public void Circle_Radius_InValidRadiusException()
    {
        Assert.Throws<Exception>(() =>
        {
            var circle = new Circle(-10);
        });
    }
}

public class TriangleTests
{
    [Test]
    public void Triangle_Area_ValidSided()
    {
        //Given
        Triangle triangle = new Triangle(3,4,5);
        //When
        float a = 3f;
        float b = 4f;
        float c = 5f;
        float area = a * b / 2; 
        //Then
        Assert.That(area, Is.EqualTo(triangle.Area).Within(Figure.ACCURACY));
    }
    [Test]
    public void Triangle_Sides_InValidSidesException_LessThanZero()
    {
        Assert.Throws<Exception>(() =>
        {
            var triangle = new Triangle(-1,2,3);
        });
    }
    [Test]
    public void Triangle_IsRightTriangle_Success()
    {
        //Given
        Triangle triangle = new Triangle(3,4,5);
        //When
        bool answer = true;
        //Then
        Assert.That(answer, Is.EqualTo(triangle.IsRightTriangle).Within(Figure.ACCURACY));
    }
    [Test]
    public void Triangle_IsRightTriangle_Failure()
    {
        //Given
        Triangle triangle = new Triangle(3,3,5);
        //When
        bool answer = false;
        //Then
        Assert.That(answer, Is.EqualTo(triangle.IsRightTriangle).Within(Figure.ACCURACY));
    }
}

public class RectangleTest
{
    [Test]
    public void Rectangle_Area_ValidSided_Success()
    {
        //Given
        Rectangle rectangle = new Rectangle(3,4);
        //When
        float a = 3f;
        float b = 4f;
        float area = a * b; 
        //Then
        Assert.That(area, Is.EqualTo(rectangle.Area).Within(Figure.ACCURACY));
    }
    [Test]
    public void Rectangle_Sides_InValidSidesException_LessThanZero()
    {
        Assert.Throws<Exception>(() =>
        {
            var rectangle = new Rectangle(-1,4);
        });
    }
}

public class SquareTest
{
    [Test]
    public void Square_Area_ValidSided_Success()
    {
        //Given
        Square square = new Square(3);
        Rectangle square_rectangle = new Square(3);
        //When
        float a = 3f;
        float area = a * a; 
        //Then
        Assert.That(area, Is.EqualTo(square.Area).Within(Figure.ACCURACY));
        Assert.That(area, Is.EqualTo(square_rectangle.Area).Within(Figure.ACCURACY));
    }
    [Test]
    public void Square_Sides_InValidSidesException_LessThanZero()
    {
        Assert.Throws<Exception>(() =>
        {
            var square = new Square(-1);
        });
    }
}

public class CompileTimeTests
{
    [Test]
    public void Figure_Area_ValidSided_Success()
    {
        //Given
        Figure rectangle = new Rectangle(3,4);
        Figure triangle = new Triangle(8,5,5);
        Figure circle = new Circle(3);
        Figure? figure = null;
        //When
        float a = 3f;
        float figure_area = a * a;
        float b = 4;
        float rectangle_area = a * b;
        float triangle_area = 12f;
        float circle_area = (float)(a * a * Math.PI);
        figure = new Square(3f);
        //Then
        Assert.That(figure_area, Is.EqualTo(figure?.Area).Within(Figure.ACCURACY));
        Assert.That(rectangle_area, Is.EqualTo(rectangle.Area).Within(Figure.ACCURACY));
        Assert.That(triangle_area, Is.EqualTo(triangle.Area).Within(Figure.ACCURACY));
        Assert.That(circle_area, Is.EqualTo(circle.Area).Within(Figure.ACCURACY));
    }
}