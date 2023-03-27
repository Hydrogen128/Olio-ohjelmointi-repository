using System;

enum Karki { PUU = 3, TERAS = 5, TIMANTTI = 50 }
enum Pera { LEHTI = 0, KANANSULKA = 1, KOTKANSULKA = 5 }

class Nuoli
{
    private Karki karki { get; set; }
    private Pera pera { get; set; }

    private double pituus { get; set; }

    public Nuoli(Karki karki, Pera pera, double pituus)
    {
        this.karki = karki;
        this.pera = pera;
        this.pituus = pituus;
    }

    public static Nuoli LuoEliittiNuoli()
    {
        return new Nuoli(Karki.TIMANTTI, Pera.KOTKANSULKA, 100);
    }

    public static Nuoli LuoAloittelijaNuoli()
    {
        return new Nuoli(Karki.PUU, Pera.KANANSULKA, 70);
    }

    public static Nuoli LuoPerusNuoli()
    {
        return new Nuoli(Karki.TERAS, Pera.KANANSULKA, 85);
    }

    public double PalautaHinta()
    {
        int karkin_hinta = (int)karki;
        int peran_hinta = (int)pera;
        double varren_hinta = pituus * 0.05;
        double hinta = karkin_hinta + peran_hinta + varren_hinta;
        return hinta;
    }

    public Karki GetKarki()
    {
        return karki;
    }

    public Pera GetPera()
    {
        return pera;
    }

    public double GetPituus()
    {
        return pituus;
    }

    public void SetKarki (Karki karki)
    {

        this.karki = karki;
    }
}

class Ohjelma
{
    static void Main()
    {
        Nuoli nuoli;
        Console.WriteLine("Valitse nuoli:");
        Console.WriteLine("1) Eliittinuoli");
        Console.WriteLine("2) Aloittelijanuoli");
        Console.WriteLine("3) Perusnuoli");
        Console.WriteLine("4) Kustomoitu nuoli");
        Console.Write("Syötä valinta (1-4): ");

        int valinta = int.Parse(Console.ReadLine());

        switch (valinta)
        {
            case 1:
                nuoli = Nuoli.LuoEliittiNuoli();
                Console.WriteLine($"Nuolen hinta on {nuoli.PalautaHinta()} " + "kultaa");
                break;

            case 2:
                nuoli = Nuoli.LuoAloittelijaNuoli();
                Console.WriteLine($"Nuolen hinta on {nuoli.PalautaHinta()} " + "kultaa");
                break;
            case 3:
                nuoli = Nuoli.LuoPerusNuoli();
                Console.WriteLine($"Nuolen hinta on {nuoli.PalautaHinta()} " + "kultaa");
                break;
            case 4:
                CustomNuoli();
                break;
        }
    }
    static void CustomNuoli()
    {
        Console.Write("Valitse nuolen kärki (puu, teräs tai timantti): ");
        Karki karki = (Karki)Enum.Parse(typeof(Karki), Console.ReadLine().ToUpper());

        Console.Write("Valitse nuolen perä (lehti, kanansulka tai kotkansulka): ");
        Pera pera = (Pera)Enum.Parse(typeof(Pera), Console.ReadLine().ToUpper());

        Console.Write("Syötä nuolen varren pituus (60-100 cm): ");
        double pituus = double.Parse(Console.ReadLine());

        Nuoli nuoli = new Nuoli(karki, pera, pituus);
        double hinta = nuoli.PalautaHinta();

        nuoli.GetKarki();
        nuoli.SetKarki(Karki.TIMANTTI);

        

        Console.WriteLine("Nuolen hinta on {0} kultaa", hinta);
    }

}


