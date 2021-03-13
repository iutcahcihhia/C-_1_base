using System;
abstract class Figure
{
    protected string figure_type = "";
    //вместо переменных наследуемые свойства:
    abstract public double Perimeter { set; get; }
    abstract public double Square { set; get; }
    abstract public string Info { get; }
}
