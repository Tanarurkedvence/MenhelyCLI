namespace MenhelyCLI
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<Kutya> kutyas = new List<Kutya>();
           using(StreamReader o = new StreamReader("../../../forras/kutyak.txt"))
            {
                o.ReadLine();
                while (!o.EndOfStream)
                {
                    string line = o.ReadLine();
                    kutyas.Add(new Kutya(line));
                }

            }

            Console.WriteLine($"5. feladat: A menhelyen {kutyas.Count()} kutya van.");

            var f6 = kutyas.Select(x => x.Kor).Average();

            Console.WriteLine($"6. feladat: A kutyák átlagéletkora: {f6:n2} év");

            var f7 = kutyas.Select(x => x.Suly).Max();

            Console.WriteLine($"7. feladat: A legnehezebb kutya: {f7.ToString()}");

            var f8 = kutyas.Where(x => x.Orokbefogadva == true).Count();
            var f9 = kutyas.Where(x => x.Orokbefogadva == false).Count();

            Console.WriteLine($"8. feladat: \n\t Már gazdára talált: {f8} kutya \n\t Még örökbefogadható: {f9} kutya");

            Console.Write($"9. feladat: Kérek egy fajtát: ");
            string fajta = Console.ReadLine();
            int counter = 0;
            foreach(var k in kutyas)
            {
                if (fajta == k.Fajta)
                {
                    Console.WriteLine($"\t{k.ToString()}");
                    counter++;
                }
                    
            }
            if (counter == 0)
            {
                Console.WriteLine("Nincs ilyen fajtájú kutya a menhelyen.");
            }

            Console.WriteLine($"10. feladat: kolykok.txt elkészült.");

            var f10 = kutyas.Where(x => x.Orokbefogadva == false && x.Kor < 3);
            using(StreamWriter i = new StreamWriter("../../../forras/kolykok.txt"))
            {
                foreach(var k in f10)
                {
                    i.WriteLine($"{k.Nev};{k.Fajta};{k.Kor}");
                }
            }

        }
    }
}
