namespace SEScripts.scripts.OOPPractice.Abstraction;

public class Square(string color, float side) : Shape(color)
{
    public readonly float Side = side;
    
    public override float GetArea()
    {
        return Side * Side;
    }
    
    public override string ToString()
    {
        return $"{base.ToString()} {GetArea()}";
    }
}