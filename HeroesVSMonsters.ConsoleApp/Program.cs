using System;
using HeroesVSMonsters.Models.MapTemplate;
using HeroesVSMonsters.Models.CharacterTemplate.Abstracts;
using HeroesVSMonsters.Models.CharacterTemplate.Heroes.Abstracts;
using HeroesVSMonsters.Models.CharacterTemplate.Heroes.Concrete;
using HeroesVSMonsters.Models.CharacterTemplate.Monsters.Abstracts;
using HeroesVSMonsters.Models.CharacterTemplate.Monsters.Concrete;

namespace HeroesVSMonsters.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Map Shorewood = new Map();
            #region Instanciation des héros et des monstres
            Human human1 = new Human("Albert", Shorewood);
            Dwarf dwarf1 = new Dwarf("Alphonse", Shorewood);
            Human human2 = new Human("Jessica", Shorewood);

            Dragonet drag1 = new Dragonet("Drakix", Shorewood);
            Orc orc1 = new Orc("Orcwarrior", Shorewood);
            Wolf wolf1 = new Wolf("Wolfy", Shorewood);
            #endregion

            #region Affichage des charactéristiques des héros et des monstres
            Console.WriteLine("Charactéristiques avant combat");
            foreach (Character hero in Shorewood.CharactersList)
            {
                if (hero is Hero)
                Console.WriteLine($"{hero.CharactersName} | Vie : {hero.HealthPoints} | Force : {hero.Strength} | Endurance : {hero.Stamina}");
            }
            Console.WriteLine();
            foreach (Character monster in Shorewood.CharactersList)
            {
                if (monster is Monster)
                Console.WriteLine($"{monster.CharactersName} | Vie : {monster.HealthPoints} | Force : {monster.Strength} | Endurance : {monster.Stamina}");
            }
            Console.WriteLine();
            #endregion

            #region Mise à mort des monstres
            human1.Strike(drag1);
            for (int i = 0; i < 3; i++)
            {
                dwarf1.Strike(orc1);
            }
            for (int i = 0; i < 5; i++)
            {

                human2.Strike(wolf1);
            }
            #endregion

            #region Ré-affichage des charactéristiques des héros et des monstres
            Console.WriteLine("Charactéristiques après combat");
            foreach (Character hero in Shorewood.CharactersList)
            {
                if (hero is Hero)
                Console.WriteLine($"{hero.CharactersName} | Vie : {hero.HealthPoints} | Force : {hero.Strength} | Endurance : {hero.Stamina}");
            }
            Console.WriteLine();
            foreach (Character monster in Shorewood.CharactersList)
            {
                if (monster is Monster)
                Console.WriteLine($"{monster.CharactersName} | Vie : {monster.HealthPoints} | Force : {monster.Strength} | Endurance : {monster.Stamina}");
            }
            Console.WriteLine();
            #endregion

            #region Affichage de l'inventaire des héros
            foreach (Character hero in Shorewood.CharactersList)
            {
                if (hero is Hero)
                {
                    Console.WriteLine($"Inventaire de {hero.CharactersName} -> {((Hero)hero)._inventory.SlotGold.Quantity} pièces d'or et {((Hero)hero)._inventory.SlotLeather.Quantity} cuirs.");
                }
            }
            #endregion
        }
    }
}
