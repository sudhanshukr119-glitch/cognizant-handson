using System;
using Exercise5_TaskManagement.Models;
using Exercise5_TaskManagement.Services;

namespace Exercise5_TaskManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            TaskLinkedList taskList = new TaskLinkedList();

            taskList.AddTask(new TaskItem(101, "Design Database", "Pending"));
            taskList.AddTask(new TaskItem(102, "Develop Login Module", "In Progress"));
            taskList.AddTask(new TaskItem(103, "Testing", "Pending"));
            taskList.AddTask(new TaskItem(104, "Deployment", "Not Started"));

            taskList.DisplayTasks();

            Console.WriteLine("\nSearching Task with ID 102");

            TaskItem task = taskList.SearchTask(102);

            if (task != null)
            {
                Console.WriteLine(task);
            }
            else
            {
                Console.WriteLine("Task Not Found.");
            }

            Console.WriteLine();

            taskList.DeleteTask(103);

            taskList.DisplayTasks();
        }
    }
}