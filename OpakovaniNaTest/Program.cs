namespace MyNamespace;

class Program
{
    public static void Main(string[] args)
    {
        var Kytara = new Guitar(24, "SCHECTER PT-8 MS Black Ops", "Eben");
        Kytara.PrintInfo();
        Kytara.PrintInfo();
        Kytara.PrintInfo();

        var cd = new Coder(3);
        cd.Encode("ahoj");
    }
}