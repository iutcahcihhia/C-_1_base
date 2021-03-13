using System;
class Triangle : Figure
{
    double a;
    double b;
    double c;
    //если ранее был задан треугольник со сторонами, отличными от 0, то при изменении периметра или площади треугольник будет заменён подобным
    public override double Perimeter 
    {
        set
        {
            double old_perimeter = Perimeter;
            double old_a = a;
            double old_b = b;
            double old_c = c;
            if (value >= 0)
            {
                if (old_perimeter > 0)
                {
                    a = old_a * value / old_perimeter;
                    b = old_b * value / old_perimeter;
                    c = old_c * value / old_perimeter;
                }
                else a = b = c = value / 3;
            }
            else throw new Exception("Периметр не может быть отрицательным!");
        }
        get
        {
            return a + b + c;
        }
    } 
    public override double Square
    {
        set
        {
            double old_square = Square;
            double old_a = a;
            double old_b = b;
            double old_c = c;
            if (value >= 0)
            {
                if (old_square > 0)
                {
                    a = old_a * Math.Pow(value / old_square, 0.5);
                    b = old_b * Math.Pow(value / old_square, 0.5);
                    c = old_c * Math.Pow(value / old_square, 0.5);
                }
                else a = b = c = Math.Pow((value * 4) / Math.Pow(3, 0.5), 0.5);
            }
            else throw new Exception("Площадь не может быть отрицательной!");
        }
        get
        {
            double p = Perimeter / 2;
            return Math.Pow(p * (p - a) * (p - b) * (p - c), 0.5);
        }
    }
    public override string Info
    {
        get
        {
            string res = String.Format("Figure type: {0} \na: {1} \nb: {2} \nc: {3} \nPerimeter: {4} \nSquare: {5} \n", figure_type, a, b, c, Perimeter, Square);
            return res;
        }
    }
    public Triangle(double a = 0, double b = 0, double c = 0) 
    {
        figure_type = "Triangle";
        if (a < 0 || b < 0 || c < 0) throw new Exception("Одна или несколько сторон отрицательны!");
        this.a = a;
        this.b = b;
        this.c = c;
        if (a != 0 || b != 0 || c != 0) //если только 1 сторона положительна, то генерируем равносторонний треугольник
        {
            if (a != 0 && b == 0 && c == 0) this.b = this.c = a;
            if (b != 0 && a == 0 && c == 0) this.a = this.c = b;
            if (c != 0 && a == 0 && b == 0) this.a = this.b = c;
        }
        if (a * b > 0 || b * c > 0 || a * c > 0) //если 2 из 3, то прямоугольный
        {
            if (a == 0) this.a = Math.Pow(Math.Pow(b, 2) + Math.Pow(c, 2), 0.5);
            if (b == 0) this.b = Math.Pow(Math.Pow(a, 2) + Math.Pow(c, 2), 0.5);
            if (c == 0) this.c = Math.Pow(Math.Pow(a, 2) + Math.Pow(b, 2), 0.5);
        }
        if (a * b * c != 0 && (a + b < c || b + c < a || a + c < b)) throw new Exception("Неккоректное задание параметров");
    }
}

