using System;
using Exercise5_TaskManagement.Models;

namespace Exercise5_TaskManagement.Services
{
    public class TaskLinkedList
    {
        private Node head;

        // Add Task
        public void AddTask(TaskItem task)
        {
            Node newNode = new Node(task);

            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node current = head;

                while (current.Next != null)
                {
                    current = current.Next;
                }

                current.Next = newNode;
            }

            Console.WriteLine("Task Added Successfully.");
        }

        // Search Task
        public TaskItem SearchTask(int taskId)
        {
            Node current = head;

            while (current != null)
            {
                if (current.Data.TaskId == taskId)
                {
                    return current.Data;
                }

                current = current.Next;
            }

            return null;
        }

        // Display All Tasks
        public void DisplayTasks()
        {
            if (head == null)
            {
                Console.WriteLine("No tasks available.");
                return;
            }

            Console.WriteLine("\nTask List:");

            Node current = head;

            while (current != null)
            {
                Console.WriteLine(current.Data);
                current = current.Next;
            }
        }

        // Delete Task
        public void DeleteTask(int taskId)
        {
            if (head == null)
            {
                Console.WriteLine("Task List is Empty.");
                return;
            }

            // Delete first node
            if (head.Data.TaskId == taskId)
            {
                head = head.Next;
                Console.WriteLine("Task Deleted Successfully.");
                return;
            }

            Node current = head;

            while (current.Next != null)
            {
                if (current.Next.Data.TaskId == taskId)
                {
                    current.Next = current.Next.Next;
                    Console.WriteLine("Task Deleted Successfully.");
                    return;
                }

                current = current.Next;
            }

            Console.WriteLine("Task Not Found.");
        }
    }
}