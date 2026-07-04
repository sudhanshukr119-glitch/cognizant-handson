using MVCPatternExample.Models;
using MVCPatternExample.Views;

namespace MVCPatternExample.Controllers;

public class StudentController
{
    private readonly Student _model;
    private readonly StudentView _view;

    public StudentController(Student model, StudentView view)
    {
        _model = model; _view = view;
    }

    public void SetName(string name) => _model.Name = name;
    public void SetGrade(string grade) => _model.Grade = grade;
    public void UpdateView() => _view.DisplayStudentDetails(_model);
}
