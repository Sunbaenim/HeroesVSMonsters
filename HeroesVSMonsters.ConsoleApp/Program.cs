using System;
using HeroesVSMonsters.Models.DiceTemplate;
using HeroesVSMonsters.Models.CharacterTemplate.Class.Heroes;

namespace HeroesVSMonsters.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Human Albert = new Human();
            Human Alphonse = new Human();

            Console.WriteLine($"Hero Albert\nVie : {Albert.HealthPoints}\nForce : {Albert.Strength}\nEndurance : {Albert.Stamina}\n");
            Console.WriteLine($"Hero Alphonse\nVie : {Alphonse.HealthPoints}\nForce : {Alphonse.Strength}\nEndurance : {Alphonse.Stamina}\n");

            Albert.Strike(Alphonse);

            Console.WriteLine($"Hero Albert\nVie : {Albert.HealthPoints}\nForce : {Albert.Strength}\nEndurance : {Albert.Stamina}\n");
            Console.WriteLine($"Hero Alphonse\nVie : {Alphonse.HealthPoints}\nForce : {Alphonse.Strength}\nEndurance : {Alphonse.Stamina}\n");


        }
    }
}
