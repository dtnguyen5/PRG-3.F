namespace GoldenSwitch2;

public partial class Form1 : Form
{
    private int _score = 0;
    private Random _random = new Random();
    public Form1()
    {
        InitializeComponent();
        _random = new Random();
    }

    private void label1_Click(object sender, EventArgs e)
    {
        throw new System.NotImplementedException();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        throw new System.NotImplementedException();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        _score++;
        label1.Text = "Score: " + _score;

        if (_score == 3)
        {
            MessageBox.Show("You won!");
            Application.Exit();
        }
        
        CatchMeIfYouCan(sender, e);
    }

    private void CatchMeIfYouCan(object sender, EventArgs e )
    {
        button1.Left = _random.Next(0, this.Size.Width - button1.Size.Width);
        button1.Top = _random.Next(0, this.Size.Height - button1.Size.Height);
    }
}