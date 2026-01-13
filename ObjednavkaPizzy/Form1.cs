namespace ObjednavkaPizzy;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        // Definované ceny
        const decimal cenaMalePizzy = 149;
        const decimal cenaVelkePizzy = 199;

        // Počet kusů 
        decimal pocetMalychPizz = numPocetMalych.Value;
        decimal pocetVelkychPizz = numPocetVelkych.Value;

        // Výpočet celkové ceny
        decimal celkovaCena = (pocetMalychPizz * cenaMalePizzy) + (pocetVelkychPizz * cenaVelkePizzy);
        
        int celkemCena = (int)celkovaCena;

        vyslednaCena.Text = $"Celkem zaplatíte: {celkemCena} Kč";
    }
    
}