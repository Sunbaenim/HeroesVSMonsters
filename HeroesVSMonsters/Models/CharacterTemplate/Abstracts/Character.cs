using System;
using System.Collections.Generic;
using System.Text;
using HeroesVSMonsters.Models.DiceTemplate;

namespace HeroesVSMonsters.Models.CharacterTemplate.Abstracts
{
    public abstract class Character
    {
        private Dice _d6;
        private Dice _d4;
        public ushort Stamina { get; }
        public ushort Strength { get; }
        public ushort HealthPoints { get; private set; }
        public Character()
        {
            _d6 = new Dice(6);
            _d4 = new Dice(4);
            Stamina = _d6.ThrowDices(4, 3);
            Strength = _d6.ThrowDices(4, 3);
            HealthPoints = (ushort)((Stamina < 5) ? Stamina - 1 : (Stamina < 10) ? Stamina : (Stamina < 15) ? Stamina + 1 : Stamina + 2);
        }
        public void Strike(Character target)
        {
            target.HealthPoints -= (ushort)(_d4.ThrowDices() + ((Stamina < 5) ? -1 : (Stamina < 10) ? 0 : (Stamina < 15) ? 1 : 2));
        }
    }
}
