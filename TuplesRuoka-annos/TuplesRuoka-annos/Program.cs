using System;

namespace Ateria
{
    class Program
    {
        enum Paaraakaaine { Nautaa, Kanaa, Kasviksia }

        enum Lisuke { Perunaa, Riisiä, Pastaa }

        enum Kastike { Curry, Tomaatti, Pippuri, Chili }

        static void Main(string[] args)
        {
            var annokset = new Tuple<Paaraakaaine, Lisuke, Kastike>[1];

            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine("Mikä pääraaka-aine?: (Nautaa, Kanaa, Kasviksia)");
                Paaraakaaine paaraakaaine = (Paaraakaaine)Enum.Parse(typeof(Paaraakaaine), Console.ReadLine());

                Console.WriteLine("Mikä lisuke?: (Perunaa, Riisiä, Pastaa)");
                Lisuke lisuke = (Lisuke)Enum.Parse(typeof(Lisuke), Console.ReadLine());

                Console.WriteLine("Mikä kastike?: (Pippuri, Chili, Tomaatti, Curry)");
                Kastike kastike = (Kastike)Enum.Parse(typeof(Kastike), Console.ReadLine());

                annokset[i] = new Tuple<Paaraakaaine, Lisuke, Kastike>(paaraakaaine, lisuke, kastike);
            }

            foreach (var annos in annokset)
            {
                Console.WriteLine("Annoksesi on siis {0} ja {1} {2}-kastikkeella", annos.Item1.ToString(), annos.Item2.ToString(), annos.Item3.ToString());
            }

            Console.ReadLine();
        }
    }
}
