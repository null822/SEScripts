namespace SEScripts.scripts.OOPPractice.MethodOverriding;

public record SalesEmployee(int Id, int Salary, int Sales = 0) : Employee(Id, Salary)
{
    public override string GetInfo() => ToString();
    
    public override string ToString()
    {
        return $"{base.ToString()} Sales:{Sales}";
    }
}