
using System;

public enum OvenTila
{
    AVATTU_LUKITSEMATTOMANA,
    AVATTU_LUKITTUNA,
    KIINNI_LUKITSEMATTOMANA
}
class Ohjelma
{
    static void Main()
    {
        OvenTila ovenTila = OvenTila.KIINNI_LUKITSEMATTOMANA;
        while (true)
        {
            Console.WriteLine("Oven tila: " + ovenTila);
            Console.WriteLine("Anna komento (Avaa lukko, Avaa, Sulje, Lukitse): ");
            string komento = Console.ReadLine();
            switch (komento.ToLower())
            {
                case "avaa lukko":
                    if (ovenTila == OvenTila.KIINNI_LUKITSEMATTOMANA)
                    {
                        ovenTila = OvenTila.AVATTU_LUKITSEMATTOMANA;
                    }
                    else
                    {
                        Console.WriteLine("Ovea ei voi avata lukon ollessa kiinni tai ovi on jo avattu.");
                    }
                    break;
                case "avaa":
                    if (ovenTila == OvenTila.AVATTU_LUKITSEMATTOMANA)
                    {
                        ovenTila = OvenTila.AVATTU_LUKITTUNA;
                    }
                    else
                    {
                        Console.WriteLine("Ovea ei voi avata, koska se ei ole avattu lukitsemattomana.");
                    }
                    break;
                case "sulje":
                    if (ovenTila == OvenTila.AVATTU_LUKITTUNA)
                    {
                        ovenTila = OvenTila.AVATTU_LUKITSEMATTOMANA;
                    }
                    else
                    {
                        Console.WriteLine("Ovea ei voi sulkea, koska se ei ole avattu lukittuna.");
                    }
                    break;
                case "lukitse":
                    if (ovenTila == OvenTila.AVATTU_LUKITSEMATTOMANA)
                    {
                        ovenTila = OvenTila.KIINNI_LUKITSEMATTOMANA;
                    }
                    else
                    {
                        Console.WriteLine("Ovea ei voi lukita, koska se ei ole avattu lukitsemattomana.");
                    }
                    break;
                default:
                    Console.WriteLine("Virheellinen komento.");
                    break;
            }
        }
    }
}
