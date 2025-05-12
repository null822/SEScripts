namespace SEScripts.scripts.OOPPractice.OperatorOverloading;

public class ComplexNumber(float real, float imaginary)
{
    public float Real { get; private set; } = real;
    public float Imaginary { get; private set; } = imaginary;
    
    public static ComplexNumber operator +(ComplexNumber a, ComplexNumber b)
    {
        return new ComplexNumber(a.Real + b.Real, a.Imaginary + b.Imaginary);
    }
    
    public override string ToString()
    {
        return $"{Real} + {Imaginary}i";
    }
}