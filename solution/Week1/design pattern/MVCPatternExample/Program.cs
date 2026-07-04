using MVCPatternExample.Controllers;
using MVCPatternExample.Models;
using MVCPatternExample.Views;

var student = new Student { Id = 1, Name = "Alice", Grade = "A" };
var view = new StudentView();
var controller = new StudentController(student, view);

Console.WriteLine("Initial details:");
controller.UpdateView();

controller.SetName("Bob");
controller.SetGrade("B+");

Console.WriteLine("\nUpdated details:");
controller.UpdateView();
