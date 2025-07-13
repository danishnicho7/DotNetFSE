using System;
class Task
{
    public int TaskId { get; set; }
    public string TaskName { get; set; }
    public string Status { get; set; }
    public Task Next { get; set; }

    public Task(int id, string name, string status)
    {
        TaskId = id;
        TaskName = name;
        Status = status;
        Next = null;
    }

    public void Display()
    {
        Console.WriteLine($"ID: {TaskId}, Name: {TaskName}, Status: {Status}");
    }
}


class TaskList
{
    private Task head;

    public void AddTask(int id, string name, string status)
    {
        Task newTask = new Task(id, name, status);
        if (head == null)
            head = newTask;
        else
        {
            Task current = head;
            while (current.Next != null)
                current = current.Next;
            current.Next = newTask;
        }
    }

    public void Traverse()
    {
        Task current = head;
        Console.WriteLine("\nAll Tasks:");
        while (current != null)
        {
            current.Display();
            current = current.Next;
        }
    }

    public Task SearchTask(int id)
    {
        Task current = head;
        while (current != null)
        {
            if (current.TaskId == id)
                return current;
            current = current.Next;
        }
        return null;
    }

    public void DeleteTask(int id)
    {
        if (head == null) return;

        if (head.TaskId == id)
        {
            head = head.Next;
            Console.WriteLine("Task deleted.");
            return;
        }

        Task current = head;
        while (current.Next != null)
        {
            if (current.Next.TaskId == id)
            {
                current.Next = current.Next.Next;
                Console.WriteLine("Task deleted.");
                return;
            }
            current = current.Next;
        }

        Console.WriteLine("Task not found.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        TaskList taskList = new TaskList();

        taskList.AddTask(1, "Design UI", "Pending");
        taskList.AddTask(2, "Write API", "In Progress");
        taskList.AddTask(3, "Testing", "Pending");

        taskList.Traverse();

        Console.WriteLine("\nSearching for Task ID 2:");
        var found = taskList.SearchTask(2);
        found?.Display();

        Console.WriteLine("\nDeleting Task ID 2:");
        taskList.DeleteTask(2);

        taskList.Traverse();
    }
}
