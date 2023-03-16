using System;

enum Karki { PUU = 3, TERAS = 5, TIMANTTI = 50 }
enum Pera { LEHTI = 0, KANANSULKA = 1, KOTKANSULKA = 5 }

class Nuoli
{
    private Karki karki;
    private Pera pera;
    private double pituus;

    public Nuoli(Karki karki, Pera pera, double pituus)
    {
        this.karki = karki;
        this.pera = pera;
        this.pituus = pituus;
    }

    public double PalautaHinta()
    {
        double karkin_hinta = (double)karki;
        double peran_hinta = (double)pera;
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
