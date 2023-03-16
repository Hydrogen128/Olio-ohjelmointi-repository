using System;
namespace EnumDemo
{
    class Ovitehtävä
    {
        static bool oviLukossa = false;
        static bool oviKiinni = false;
        static bool loppu = false;
        enum Valinta
        {
            Auki = 1,
            Kiinni,
            Lukossa,
            Loppu
        };

        static void Main(string[] args)
        {
            Console.WriteLine("Ovi on " + Valinta.Auki + ", mitä haluat tehdä?");
            while (loppu == false)
            {
                string käsky = Console.ReadLine();
                if (käsky == "sulje")
                {
                    Console.WriteLine("Ovi on " + Valinta.Kiinni + ", mitä haluat tehdä?");
                    Ovitehtävä.oviKiinni = true;
                    Ovitehtävä.oviLukossa = false;
                }
                if (käsky == "lukitse")
                {
                    if (!Ovitehtävä.oviKiinni)
                    {
                        Console.WriteLine("Sulje ovi ennen kuin lukitset oven!");
                    }
                    else
                    {
                        Console.WriteLine("Ovi on " + Valinta.Lukossa + ", mitä haluat tehdä?");
                        Ovitehtävä.oviLukossa = true;
                        Ovitehtävä.oviKiinni = false;
                    }
                }
                if (käsky == "avaa")
                {
                    if (oviLukossa == true)
                    {
                        Console.WriteLine("Poista lukko ekaksi!");
                    }
                    else
                    {
                        Console.WriteLine("Ovi on " + Valinta.Auki + ", mitä haluat tehdä?");
                        Ovitehtävä.oviKiinni = false;
                    }
                }
                if (käsky == "lopeta")
                {
                    loppu = true;
                }
            }
        }
    }
}