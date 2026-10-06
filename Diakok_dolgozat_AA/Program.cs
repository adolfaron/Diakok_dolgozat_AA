using Diakok_dolgozat_AA.Model;
using System.Net.WebSockets;
namespace Diakok_dolgozat_AA
{
    internal class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            List<Diak> diakok = new List<Diak>();

            diakok.Add(new Diak(1, "Pityu", "Férfi", 1980, 4.2, true));
            diakok.Add(new Diak(2, "Béla", "Férfi", 1982, 3.2, false));
            diakok.Add(new Diak(3, "Gizi", "Nő", 1973, 4.8));
            diakok.Add(new Diak(4, "Joli", "Nő", 1999, 2.5));
            Console.WriteLine("4.2. feladat diak objektumok kiiratása:");
            foreach (Diak diak in diakok)
            {
                Console.WriteLine(diak.ToString());
            }

            Console.WriteLine("\n4.3. Diákok létszámának kiiratása:");
            Console.WriteLine(Diak.LetszamSzoveg());

            Console.WriteLine("\n4.4. Két tetszőleges diák objektum nevének és életkorának (évben megadva) kiiratása:");
            int i = rnd.Next(0, diakok.Count);
            Console.WriteLine($"{i+1}. {diakok[i].Nev} {diakok[i].Eletkor()} éves");
            i = rnd.Next(0, diakok.Count);
            Console.WriteLine($"{i+1}. {diakok[i].Nev} {diakok[i].Eletkor()} éves");

            Console.WriteLine("\n4.5. A listába került diákok azonosítójának és nevének kiiratása egymás mellé.");
            foreach (Diak diak in diakok)
            {
                Console.Write($"{diak.Id}:{diak.Nev} ");
            }
            Console.WriteLine($"\n\n4.6. Összesen {diakok.Where(x => x.Bajai == true).Count()} bajai diák van a listában.");
            Diak ujDiak = new Diak();

            while (true)
            {
                Console.WriteLine("\nAdd meg az új diák azonosítóját:");
                try
                {
                    ujDiak.Id = int.Parse(Console.ReadLine());
                    List<int> IdK = new List<int>();
                    diakok.ForEach(diak =>
                    {
                        IdK.Add(diak.Id);
                    });
                    if (IdK.Contains(ujDiak.Id))
                    {
                        Console.WriteLine("Ez az Id foglalt!");
                        continue;
                    }
                    break;
                }
                catch
                {
                    Console.WriteLine("Hibás adat! ");
                }
            }
            while (true)
            {
                Console.WriteLine("Add meg az új diák nevét:");
                ujDiak.Nev = Console.ReadLine();
                if (!string.IsNullOrEmpty(ujDiak.Nev))
                {
                    break;
                }
                Console.WriteLine("Hibás adat!");
            }
            while (true)
            {
                Console.WriteLine("Add meg az új diák nemét:");
                ujDiak.Nem = Console.ReadLine();
                if (!string.IsNullOrEmpty(ujDiak.Nem))
                {
                    break;
                }
                Console.WriteLine("Hibás adat!");
            }

            while (true)
            {
                Console.WriteLine("Add meg az új diák születési évét:");
                try
                {
                    ujDiak.SzuletesiEv = int.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Hibás adat! ");
                }
            }

            while (true)
            {
                Console.WriteLine("Add meg az új diák átlagát: (pl. 4,55)");
                try
                {
                    ujDiak.Atlag = double.Parse( Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Hibás adat! ");
                }
            }
            while (true)
            {
                Console.WriteLine("Add meg az új diák bajai-e vagy sem (true/false):");
                try
                {
                    //ujDiak.Bajai = Console.ReadLine()=="true"?true:false;
                    ujDiak.Bajai = bool.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Hibás adat! ");
                }
            }

            Console.WriteLine("\n5.2 Az új diák objektum:");
            Console.WriteLine(ujDiak.ToString());
            diakok.Add(ujDiak);

            Console.WriteLine("\n5.3.A lista elemeinek száma:");
            Console.WriteLine($"Jelenleg {diakok.Count} eleme van.");













        }
    }
}
