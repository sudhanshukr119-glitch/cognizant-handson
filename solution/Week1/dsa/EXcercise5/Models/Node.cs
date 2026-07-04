namespace Exercise5_TaskManagement.Models
{
    public class Node
    {
        public TaskItem Data { get; set; }
        public Node Next { get; set; }

        public Node(TaskItem task)
        {
            Data = task;
            Next = null;
        }
    }
}