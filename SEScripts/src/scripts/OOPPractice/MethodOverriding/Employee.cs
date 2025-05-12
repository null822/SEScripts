namespace SEScripts.scripts.OOPPractice.MethodOverriding;

// note that the Method Overriding task is identical to the Inheritance task, so it is only done once

public record Employee(int Id, int Salary)
{
    public virtual string GetInfo() => ToString();
    
    public override string ToString()
    {
        return $"EmployeeID:{Id} Salary:{Salary}";
    }
}