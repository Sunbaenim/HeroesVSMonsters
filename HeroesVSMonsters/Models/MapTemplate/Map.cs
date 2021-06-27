using System.Collections.Generic;
using HeroesVSMonsters.Models.CharacterTemplate.Abstracts;

namespace HeroesVSMonsters.Models.MapTemplate
{
    public class Map
    {
        public List<Character> CharactersList { get; }
        public string Name { get; set; }
        public Map()
        {
            CharactersList = new List<Character>();
        }
    }
}
