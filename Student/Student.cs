namespace MyNamespace;

public class Student
/*
Úloha 2 – Student
Zadání:
Vytvořte třídu Student, která uchovává informace o známkách a dokáže vypočítat průměr.

Třída má vlastnosti:
    string Name
    int[] Grades – pole známek (1–5)

Má konstruktor, který nastaví jméno a známky.

Obsahuje metody:

    double GetAverage() – vrátí průměr známek
    void PrintResult() – vypíše jméno, průměr a informaci o prospěchu:

        průměr < 1.5 → výborný
        1.5–2.5 → chvalitebný
        2.5–3.5 → dobrý
        jinak → nedostatečný

Ukázka použití:
public class Program {
    public static void Main(string[] args){
        var student = new Student("Petr", new int[] {1, 2, 1, 1, 2});
        student.PrintResult();
    }
}
--- Konzole ---
/*
Student: Petr
Průměr: 1.40
Prospěch: výborný
* /
 */

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