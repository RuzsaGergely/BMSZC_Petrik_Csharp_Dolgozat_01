namespace RGG_Csharp_dolgozat_01_folytatas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BMSZC Petrik - Ruzsa Gergely Gábor - 2/14. SL");
            Feladat01();
            Feladat02();
            Feladat03();
            Feladat04();
        }

        public static void Feladat01()
        {
            Console.WriteLine("1. és 4. feladat:");
            // Most feltételezzük, hogy a felhasználó számot ír be.
            Console.WriteLine("Adj meg egy számot (A):");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Adj meg egy számot (B):");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Adj meg egy számot (C):");
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine("Adj meg egy számot (D):");
            double d = double.Parse(Console.ReadLine());

            double eredmeny = (a / b) + (c / d);
            Console.WriteLine($"Az eredmény: {eredmeny.ToString("G29")}");
        }

        public static void Feladat02()
        {
            Console.WriteLine("2. feladat:");
            // Szemfülesek észrevehetik, hogy az előző solution-ből másoltam ki.
            Console.WriteLine("Adj meg egy számot!");
            string bemenet_n_string = Console.ReadLine();
            int bemenet_n = 0;
            while (!int.TryParse(bemenet_n_string, out int n) || n % 2 != 0)
            {
                Console.WriteLine("Nem számot vagy nem páros számot írtál be! Add meg újra!");
                bemenet_n_string = Console.ReadLine();
            }
            bemenet_n = int.Parse(bemenet_n_string);
            Console.WriteLine("A megadott szám megfelelő");
        }

        public static void Feladat03()
        {
            Console.WriteLine("3. feladat:");
            Console.WriteLine("Adj meg egy számot!");
            string bemenet_n_string = Console.ReadLine();
            int bemenet_n = 0;
            while (!int.TryParse(bemenet_n_string, out int n) || n < 1)
            {
                Console.WriteLine("Nem számot vagy kisebb számot írtál be mint 1! Add meg újra!");
                bemenet_n_string = Console.ReadLine();
            }
            bemenet_n = int.Parse(bemenet_n_string);
            Console.WriteLine(bemenet_n % 5);
        }

        public static void Feladat04()
        {
            // Ugyanaz mint az első feladat
            Feladat01();
        }
    }
}