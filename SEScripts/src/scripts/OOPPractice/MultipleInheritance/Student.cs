namespace SEScripts.scripts.OOPPractice.MultipleInheritance;

public interface IStudent
{
    public int StudentId { get; }
    public int DepartmentId { get; }
    
    public string GetId() => ToString();
    
    public string ToString()
    {
        return $"StudentID:{StudentId} DepartmentID:{DepartmentId}";
    }
}