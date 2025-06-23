using System;

public class Student
{
    public string Name { get; set; }
    public string Id { get; set; }
    public string Grade { get; set; }
}

public class StudentView
{
    public void DisplayStudentDetails(Student student)
    {
        Console.WriteLine("=== Student Details ===");
        Console.WriteLine($"ID: {student.Id}");
        Console.WriteLine($"Name: {student.Name}");
        Console.WriteLine($"Grade: {student.Grade}");
        Console.WriteLine();
    }
}

public class StudentController
{
    private Student student;
    private StudentView view;

    public StudentController(Student student, StudentView view)
    {
        this.student = student;
        this.view = view;
    }

    public void SetStudentName(string name)
    {
        student.Name = name;
    }

    public void SetStudentId(string id)
    {
        student.Id = id;
    }

    public void SetStudentGrade(string grade)
    {
        student.Grade = grade;
    }

    public string GetStudentName() => student.Name;
    public string GetStudentId() => student.Id;
    public string GetStudentGrade() => student.Grade;

    public void UpdateView()
    {
        view.DisplayStudentDetails(student);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student student = new Student
        {
            Name = "John Doe",
            Id = "S1234",
            Grade = "A"
        };

        StudentView view = new StudentView();

        StudentController controller = new StudentController(student, view);

        controller.UpdateView();

        controller.SetStudentName("Jane Smith");
        controller.SetStudentGrade("A+");

        controller.UpdateView();
    }
}
