using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assign1 = new Assignment();
        assign1.SetStudentName("Samuel Bennet");
        assign1.SetTopic("Multiplication");


        Console.WriteLine(assign1.GetSummary());

        MathAssignment math1 = new MathAssignment();
        math1.SetTextBookSection("Section 5");
        math1.SetStudentName("Harry Freeman");
        math1.SetTopic("Caluclus");
        math1.SetProblems("Problems 24-76");

        Console.WriteLine(math1.GetSummary());
        Console.WriteLine(math1.GetHomeworkList());

        WritingAssignment write1 = new WritingAssignment();
        write1.SetStudentName("Hilda Garcia");
        write1.SetTopic("English 101");
        write1.SetTitle("The Greatest English Class");

        Console.WriteLine(write1.GetSummary());
        Console.WriteLine(write1.GetWritingInformation());
    }
}