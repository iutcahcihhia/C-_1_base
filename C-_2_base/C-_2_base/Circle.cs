using System;
class Circle : Figure
{
    double radius;
    public double Radius
    {
        set
        {
            if (value >= 0) radius = value;
            else throw new Exception("Радиус не может быть отрицательным!");
        }
        get
        {
            return radius;
        }
    }
    public double Diameter
    {
        set
        {
            if (value >= 0) radius = value / 2;
            else throw new Exception("Диаметр не может быть отрицательным!");
        }
        get
        {
            return radius * 2;
        }
    }
    public override double Perimeter
    {
        set
        {
            if (value >= 0) radius = value / (2 * Math.PI);
            else throw new Exception("Периметр не может быть отрицательным!");
        }
        get
        {
            return 2 * Math.PI * radius;
        }
    }
    public override double Square
    {
        set
        {
            if (value >= 0) radius = Math.Pow(value / Math.PI, 0.5);
            else throw new Exception("Площадь не может быть отрицательной!");
        }
        get
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
    public override string Info 
    { 
        get
        {
            string res = String.Format("Figure type: {0} \nRadius: {1} \nDiameter: {2} \nPerimeter: {3} \nSquare: {4} \n", figure_type, Radius, Diameter, Perimeter, Square);
            return res;
        }   
    }
    public Circle(double radius = 0)
    {
        figure_type = "Circle";
        if (radius < 0) throw new Exception("Радиус не может быть отрицательным!");
        this.radius = radius;
    }
}

