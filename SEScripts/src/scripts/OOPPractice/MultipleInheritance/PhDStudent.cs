namespace SEScripts.scripts.OOPPractice.MultipleInheritance;

public record PhDStudent(int StudentId, int EmployeeId, int DepartmentId) : IStudent, IFaculty
{
    public string GetId() => ToString();
    
    public override string ToString()
    {
        return $"StudentID:{StudentId} EmployeeID:{EmployeeId} DepartmentID:{DepartmentId}";
    }
}