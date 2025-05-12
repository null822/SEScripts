namespace SEScripts.scripts.OOPPractice.Abstraction;

public abstract class Shape(string color)
{
    public readonly string Color = color;
    public abstract float GetArea();

    public override string ToString()
    {
        return Color;
    }
}