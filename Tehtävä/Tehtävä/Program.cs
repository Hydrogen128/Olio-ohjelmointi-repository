using System;
using System.Numerics;

float ritariHP = 15;
float örkkiHP = 15;

Console.Clear(); 
Console.WriteLine("Olet ritari ja örkki hyökkää kimppuusi");


while (ritariHP > 0 && örkkiHP > 0)
{
    int satunnaisDMG = Damage(1, 10);
    int satunnaisDMG2 = Damage(1, 6);

    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("Ritarin HP: " + ritariHP + "/15" + "   " + "Örkin HP: " + örkkiHP + "/15");
    Console.WriteLine("Ritari! Mitä aiot tehdä?");
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("1 - Hyökkää");
    Console.WriteLine("2 - Puolusta");
    int ritariValinta = Convert.ToInt32(Console.ReadLine()); //Pelaaja päättää, mitä ritari tekee




    if (ritariValinta == 1)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Hyökkäät miekallasi!");
        Console.WriteLine("Sivallat örkkiä miekallasi. Teet örkkiin " + satunnaisDMG + " vahinkopistettä");
        Console.ForegroundColor = ConsoleColor.Red;
        örkkiHP -= satunnaisDMG;
    }

    if (ritariValinta == 2)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Nostat kilpesi puolustukseesi!");
    }

    if (örkkiHP > 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Orkki hyökkää sinua kohti nuijallaan!");

        if (ritariValinta == 2)
        {
            Console.WriteLine("Nuija kumahtaa kilpeesi tehden sinuun " + satunnaisDMG2 / 2 + " vahinkopistettä");
            ritariHP -= satunnaisDMG2 / 2;
        }
        else
        {
            Console.WriteLine("Nuija tekee sinuun " + satunnaisDMG2 + " vahinkopistettä");
            ritariHP -= satunnaisDMG2;
        }
    }

    if (örkkiHP <= 0)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Örkki kuoli, Hyvää työtä!");
    }

    if (ritariHP <= 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Ritari kuoli, game over!");
    }
}

int Damage(int minDMG, int maxDMG)
{
    Random random = new Random();
    int damage = random.Next(minDMG, maxDMG + 1);
    return damage;
}