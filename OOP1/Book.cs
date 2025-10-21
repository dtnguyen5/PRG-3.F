namespace MyNamespace;

public class Book
{
    private int pages;
    private bool tvrdeDesky;
    
    private String author;
    private int year;
    private String name;

    public Book(int pages, bool tvrdeDesky, string author, int year, string name)
    {
        this.pages = pages;
        this.tvrdeDesky = tvrdeDesky;
        this.author = author;
        this.year = year;
        this.name = name;
    }
    
    
    
}