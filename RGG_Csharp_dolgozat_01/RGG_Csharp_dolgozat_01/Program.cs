namespace RGG_Csharp_dolgozat_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BMSZC Petrik - Ruzsa Gergely Gábor 2/14. SL - C# dolgozat 01");

            Console.WriteLine("\n#### N valós számok ####");

            Console.WriteLine("Adj meg egy számot!");
            string bemenet_n_string = Console.ReadLine();
            int bemenet_n = 0;
            while(!int.TryParse(bemenet_n_string, out int n)) {
                Console.WriteLine("Nem számot írtál be! Add meg újra!");
                bemenet_n_string = Console.ReadLine();
            }
            bemenet_n = int.Parse(bemenet_n_string);

            int[] tomb = new int[bemenet_n];

            Random rnd = new Random();
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = rnd.Next(0, 101);
            }

            Feladat4Kiir(tomb.Where(x => x % 2 == 0).ToList(), "darab páros szám van. Ezek a következők: ");
            Feladat4Kiir(tomb.Where(x => x % 2 != 0).ToList(), "darab páratlan szám van. Ezek a következők: ");
            Feladat4Kiir(tomb.Where(x => IsPrime(x)).ToList(), "darab prímszám van. Ezek a következők: ");

            Console.WriteLine($"A tömb átlaga: {tomb.Average()}");
            Console.WriteLine($"A tömb minimuma: {tomb.Min()}");
            Console.WriteLine($"A tömb maximuma: {tomb.Max()}");

            Console.WriteLine("\n#### Szavak ####");

            string[] szavak = new string[5];

            for (int i = 0;i < szavak.Length; i++)
            {
                Console.WriteLine("Adj meg egy szót: ");
                string bemenet_szo = Console.ReadLine();
                while (bemenet_szo.Contains(' ') || String.IsNullOrWhiteSpace(bemenet_szo) || String.IsNullOrEmpty(bemenet_szo))
                {
                    Console.WriteLine("[HIBA] Adj meg egy szót: ");
                    bemenet_szo = Console.ReadLine();
                }
                szavak[i] = bemenet_szo;
            }

            Console.WriteLine($"\nA leghosszabb szó: {szavak.OrderByDescending(x => x.Length).First()}");
            Console.WriteLine($"A legrövidebb szó: {szavak.OrderBy(x => x.Length).First()}");

            Console.WriteLine("\nEgyező szavak: \n");
            foreach (var item in szavak.GroupBy(x=>x))
            {
                int elofordulas = szavak.Count(x => x == item.Key);
                if (elofordulas > 1)
                {
                    Console.WriteLine($"{item.Key} ({elofordulas})");
                }
            }

            Console.ReadLine();
        }

        public static void Feladat4Kiir(List<int> bemenet, string szoveg)
        {
            Console.WriteLine($"{bemenet.Count} {szoveg}");
            foreach (var item in bemenet)
            {
                Console.Write($"{item},");
            }
            Console.Write("\n\n");
        }

        // A matematika nem az erősségem.
        // Referencia: https://dev.to/bytehide/prime-numbers-in-c-a-detailed-guide-442n
        public static bool IsPrime(int num)
        {
            if (num <= 1) return false;
            if (num == 2) return true;
            for (int i = 2; i * i <= num; i++)
                if (num % i == 0) return false;
            return true;
        }
    }
}