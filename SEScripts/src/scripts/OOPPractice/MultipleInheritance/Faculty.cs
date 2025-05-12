namespace SEScripts.scripts.OOPPractice.MultipleInheritance;

public interface IFaculty
{
    public int EmployeeId { get; }
    public int DepartmentId { get; }
    
    public string GetId() => ToString();
    
    public string ToString()
    {
        return $"EmployeeID:{EmployeeId} DepartmentID:{DepartmentId}";
    }
}