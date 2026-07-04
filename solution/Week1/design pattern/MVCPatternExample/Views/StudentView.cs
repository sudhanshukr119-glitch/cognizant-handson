using MVCPatternExample.Models;

namespace MVCPatternExample.Views;

public class StudentView
{
    public void DisplayStudentDetails(Student student) =>
        Console.WriteLine($"ID: {student.Id} | Name: {student.Name} | Grade: {student.Grade}");
}
