using System;
using HeroesVSMonsters.Models.CharacterTemplate.Heroes.Concrete;
using HeroesVSMonsters.Models.CharacterTemplate.Abstracts;
using HeroesVSMonsters.Models.CharacterTemplate.Monsters.Concrete;

namespace HeroesVSMonsters.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Human Albert = new Human();
            Console.WriteLine($"Hero Albert ({Albert.GetType()})\nVie : \nForce : {Albert.Strength}\nEndurance : {Albert.Stamina}\n");
            Dwarf Alphonse = new Dwarf();
            Human Jessica = new Human();

            Dragonet drag1 = new Dragonet();
            Orc orc1 = new Orc();
            Wolf wolf1 = new Wolf();

            Console.WriteLine($"Hero Albert ({Albert.GetType()})\nVie : \nForce : {Albert.Strength}\nEndurance : {Albert.Stamina}\n");
            Console.WriteLine($"Hero Alphonse ({Alphonse.GetType()})\nVie : \nForce : {Alphonse.Strength}\nEndurance : {Alphonse.Stamina}\n");
            Console.WriteLine($"Hero Jessica ({Jessica.GetType()})\nVie : \nForce : {Jessica.Strength}\nEndurance : {Jessica.Stamina}\n");

            Albert.Strike(drag1);
            Alphonse.Strike(orc1);
            for (int i = 0; i < 5; i++)
            {
                Jessica.Strike(wolf1);
            }
            Console.WriteLine("============================================");

            Console.WriteLine($"Dragonnet\nVie : \nForce : {drag1.Strength}\nEndurance : {drag1.Stamina}\n");
            Console.WriteLine($"Orc\nVie : \nForce : {orc1.Strength}\nEndurance : {orc1.Stamina}\n");
            Console.WriteLine($"Loup\nVie : \nForce : {wolf1.Strength}\nEndurance : {wolf1.Stamina}\n");
        }
    }
}
