namespace WinFormsApp1;

public partial class Form1 : Form
{
    private string _msg;
    private int _skore;
    public Form1()
    {
        _msg = "Ukončuji život";
        _skore = 0;
        InitializeComponent();
        
    }

    private void label1_Click(object sender, EventArgs e)
    {
        throw new System.NotImplementedException();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        Console.WriteLine(_msg);
        Application.Exit();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        throw new System.NotImplementedException();
    }

    private void button2_Click(object sender, EventArgs e)
    {
        _skore ++;
        Console.WriteLine(_skore);
    }
}