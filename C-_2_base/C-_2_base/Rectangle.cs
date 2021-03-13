using System;
class Rectangle : Figure
{

    double a;
    double b;
    //если ранее был задан прямоугольник со сторонами, отличными от 0, то при изменении периметра или площади прямоугольник будет заменён подобным
    public override double Perimeter
    {
        set
        {
            double old_perimeter = Perimeter;
            double old_a = a;
            double old_b = b;
            if (value >= 0)
            {
                if (old_perimeter > 0)
                {
                    a = old_a * value / old_perimeter;
                    b = old_b * value / old_perimeter;
                }
                else a = b = value / 4;
            } else throw new Exception("Периметр не может быть отрицательным!");
        }
        get 
        { 
            return 2 * (a + b); 
        }
    }
    public override double Square
    {
        set
        {
            double old_square = Square;
            double old_a = a;
            double old_b = b;
            if (value >= 0)
            {
                if (old_square >= 0)
                {
                    a = old_a * Math.Pow(value / old_square, 0.5);
                    b = old_b * Math.Pow(value / old_square, 0.5);
                }
                else a = b = Math.Pow(value, 0.5);
            }
            else throw new Exception("Площадь не может быть отрицательной!");
        }
        get 
        { 
            return a * b; 
        }
    }
    public override string Info
    {
        get
        {
            string res = String.Format("Figure type: {0} \na: {1} \nb: {2} \nPerimeter: {3} \nSquare: {4} \n", figure_type, a, b, Perimeter, Square);
            return res;
        }
    }
    public Rectangle(double a = 0, double b = 0)
    {
        figure_type = "Rectangle";
        if (a < 0 || b < 0) throw new Exception("Одна или несколько сторон отрицательны!");
        this.a = a;
        this.b = b;
        if (a * b == 0) //если одна из сторон положительная, генерируем квадрат с положительной стороной
        {
            if (a == 0) this.a = b;
            else this.b = a;
        }
    }
}

