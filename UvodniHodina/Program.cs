using System;

namespace UvodniHodina
{
    class Program
    {
        public static void Main(string[] args)
        {
           
            Console.WriteLine("Zadejte své jméno:");
            string jmeno = Console.ReadLine();
            Console.WriteLine("Zadejte svoje příjmení:");
            string prijmeni = Console.ReadLine();

            Console.WriteLine($"Ahoj, {jmeno} {prijmeni}!");
            

            bool bezi = !false;

            var y = 1; // automaticky pozná datový typ

            
            // <------------------ vstup čísla od uživatele ------------------>
            // --------- 1. možnost ---------
            int a = int.Parse(Console.ReadLine());
            
            // --------- 2. možnost ---------
            string b = Console.ReadLine();
            int c = int.Parse(b);
            
            // --------- 3. možnost ---------
            int d;
            int.TryParse(Console.ReadLine(), out d );


        }
    }
}