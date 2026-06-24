using System;

public class Calculator
{
    public double GetTotalArea(params IShape[] shapes)
    {
        double res = 0;
        foreach (var shape in shapes)
        {
           res += shape.CalcArea();
        }
      
        return Math.Round(res, 2);
    }
}

public interface IShape
{
  double CalcArea();
}

public class Square : IShape
{
  private readonly double side;
  
  public Square(double side)
  {
    this.side = side;
  }
  
  public double CalcArea()
  {
    return this.side * this.side;
  }
}

public class Rectangle : IShape
{
  private readonly double height;
  private readonly double width;
  
  public Rectangle(double height, double width)
  {
    this.height = height;
    this.width = width;
  }
  
  public double CalcArea()
  {
    return this.height * this.width;
  }
}

public class Circle : IShape
{
  private readonly double radius;
  
  public Circle(double radius)
  {
    this.radius = radius;
  }
  
  public double CalcArea()
  {
    return Math.PI * this.radius * this.radius;
  }
}

public class Triangle : IShape
{
  private double _base;
  private double height;
  
  public Triangle(double base_, double height)
  {
    this._base = base_;
    this.height = height;
  }
  
  public double CalcArea()
  {
    return 0.5 * this._base * this.height;
  }
}
