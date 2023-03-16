using System;

namespace LohikäärmeTehtävä
{
    class Program
    {
        static void Main(string[] args)
        {
            int vuoro = 1;

            //Dragon hp
            int lohikäärme = 10;
            //Damage
            int vahinko = 1;
            //City hp
            int kaupunki = 15;

            Console.WriteLine("Määrittele kaupungin etäisyys lohikäärmeestä");
            int distance = Convert.ToInt32(Console.ReadLine());

            Console.Clear();
            while (lohikäärme > 0)
            {

                Console.WriteLine("TILANNE; " + "" + "Vuoro " + vuoro + ", Lohikäärmeen hp; " + lohikäärme + "" + ", Kaupungin hp; " + kaupunki + ".");

                vuoro += 1;

                kaupunki -= 1;

                if (vuoro % 3 == 0)
                {
                    Console.WriteLine("Kanuuna tekee tällä kierroksella 3 pistettä vahinkoa");
                    vahinko = 3;
                }
                else if (vuoro % 5 == 0)
                {
                    Console.WriteLine("Kanuuna tekee tällä kierroksella 3 vahinkopistettä");
                    vahinko = 3;
                }
                else if (vuoro % 3 == 0 && vuoro % 5 == 0)
                {
                    Console.WriteLine("Kanuuna tekee tällä kierroksella 10 vahinkopistettä");
                    vahinko = 10;
                }
                else
                {
                    Console.WriteLine("Kanuuna tekee tällä kierroksella 1 vahinkopistettä");
                }

                Console.WriteLine("Mille etäisyydelle kanuunalla ammutaan?");
                int shoot = Convert.ToInt32(Console.ReadLine());

                if (Convert.ToInt32(shoot) < Convert.ToInt32(distance))
                {
                    Console.WriteLine("Ammus lensi lohikäärmeen ali");
                }
                else if (Convert.ToInt32(shoot) > Convert.ToInt32(distance))
                {
                    Console.WriteLine("Ammus lensi lohikäärmeen yli");
                }
                else if (Convert.ToInt32(shoot) == Convert.ToInt32(distance))
                {
                    Console.WriteLine(" osui lohikäärmeeseen");
                    lohikäärme = lohikäärme - vahinko;
                }


                if (kaupunki == 0)
                {
                    Console.WriteLine("Kaupunki tuhoutui");
                    Console.WriteLine("Etäisyys oli " + distance);
                    break;
                }
                if (lohikäärme <= 0)
                {
                    Console.WriteLine("Voitimme!");
                    break;
                }
            }
        }
    }
}