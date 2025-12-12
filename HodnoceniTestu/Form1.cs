namespace HodnoceniTestu;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        // Počet bodů
        int pocetBodu = (int)numBody.Value;
        
        // Proměnná pro uložení známky
        int znamka;

        // Určování známky podle počtu bodů
        if (pocetBodu >= 90)
        {
            znamka = 1;
        }
        else if (pocetBodu >= 75)
        {
            znamka = 2;
        }
        else if (pocetBodu >= 60)
        {
            znamka = 3;
        }
        else if (pocetBodu >= 40)
        {
            znamka = 4;
        }
        else
        {
            znamka = 5;
        }

        // Výpis výsledku
        string vyslednyText = $"Za {pocetBodu} bodů máš známku {znamka}.";
        vysledek.Text = vyslednyText;
        
        // Přeju dobrou noc :)
    }
}