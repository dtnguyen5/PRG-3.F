namespace Spropitne;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }


    private void btncalc_Click(object sender, EventArgs e)
    {
        decimal tipAmount = (nudTip.Value / 100.0m) * nudPrice.Value;
        decimal totalAmount = nudPrice.Value + tipAmount;
        decimal amountPerPerson = totalAmount / nudPeople.Value;
        
        lblTotal.Text = $"{totalAmount} kč";
        lblPerPerson.Text = $"{amountPerPerson} Kč";
    }
}