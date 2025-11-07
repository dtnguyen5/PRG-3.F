namespace MyNamespace;

public class Student
{
    // <---------------------- Vlastnosti třídy ---------------------->
    public string Name { get; set; }
    public int[] Grades { get; set; }

    // <---------------------- Konstruktor třídy ---------------------->
    public Student(string name, int[] grades)
    {
        Name = name;
        Grades = grades;
    }
    
    // <---------------------- Metoda pro výpočet průměru ---------------------->
    public double GetAverage()
    {
        if (Grades.Length == 0)
        {
            return 0;
        }
        
        int sum = 0;
        foreach (int grade in Grades)
        {
            sum += grade;
        }
        
        double average = (double)sum / Grades.Length;
        average = Math.Round(average, 2);
        return average;
    }
    
    // <---------------------- Metoda pro vypsání výsledku ---------------------->
    public void PrintResult()
    {
        double average = GetAverage();
        string grade;
        
        if (average < 1.5)
        {
            grade = "výborný";
        }
        else if (average < 2.5)
        {
            grade = "chvalitebný";
        }
        else if (average < 3.5)
        {
            grade = "dobrý";
        }
        else
        {
            grade = "nedostatečný";
        }
        
        Console.WriteLine($"Student: {Name}");
        Console.WriteLine($"Průměr: {average.ToString("0.00")}");
        Console.WriteLine($"Prospěch: {grade}");
    }
}