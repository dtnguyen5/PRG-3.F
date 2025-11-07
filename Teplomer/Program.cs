namespace MyNamespace;

class Program
{
    public static void Main(string[] args)
    {
        Random rnd = new Random();
        int[] temperatures = new int[7];
        
        // naplnění pole náhodnými teplotami
        for (int i = 0; i < temperatures.Length; i++)
        {
            temperatures[i] = rnd.Next(-5, 26); // 26 protože horní mez je v Next vyloučená
        }

        // výpis teplot
        Console.Write("Teploty: [");
        for (int i = 0; i < temperatures.Length; i++)
        {
            Console.Write(temperatures[i]);
            if (i < temperatures.Length - 1)
                Console.Write(", ");
        }
        Console.WriteLine("]");
        
        // výpočty
        int min = temperatures[0];
        int max = temperatures[0];
        int sum = 0;
        int nad10 = 0;
        
        foreach (int t in temperatures)
        {
            if (t < min)
            {
                min = t;
            }

            if (t > max)
            {
                max = t;
            }
            
            sum += t;
            
            if (t > 10)
            {
                nad10 ++;
            }
        }
        
        double avg = (double)sum / temperatures.Length;
    
        // výpis výsledků
        Console.WriteLine("Nejnižší teplota: " + min + " °C");
        Console.WriteLine("Nejvyšší teplota: " + max + " °C");
        Console.WriteLine("Průměrná teplota: " + Math.Round(avg, 2) + " °C");
        Console.WriteLine("Počet dní nad 10 °C: " + nad10);
    }
}