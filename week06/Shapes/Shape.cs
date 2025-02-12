public abstract class Shape
{
    private string color;

    public string Color
    {
        get { return color; }
        set { color = value; }
    }

    public Shape(string color)
    {
        this.color = color;
    }

    public abstract double GetArea();
}
