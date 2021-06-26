using System;
using System.Collections.Generic;
using HeroesVSMonsters.Models.CharacterTemplate.Abstracts;
using HeroesVSMonsters.Models.CharacterTemplate.Monsters.Concrete;

namespace HeroesVSMonsters.Models.CharacterTemplate.Heroes.Abstracts
{
    public abstract class Hero : Character
    {
        private List<ushort> Inventory;
        public Hero()
        {
            Inventory = new List<ushort>();
        }
        public void Depouiller(Character monster)
        {
            switch (monster)
            {
                case Dragonet dragonet:
                    this.Inventory.Add(dragonet.QuantityOfGold);
                    this.Inventory.Add(dragonet.QuantityOfLeather);
                    break;
                case Orc orc:
                    this.Inventory.Add(orc.QuantityOfGold);
                    break;
                case Wolf wolf:
                    this.Inventory.Add(wolf.QuantityOfLeather);
                    break;
                default:
                    break;
            }
        }
        public override void Strike(Character target)
        {
            base.Strike(target);
            if (target.HealthPoints <= 0)
            {
                Depouiller(target);
                base.CharactersList.Remove(this);
            }
        }
    }
}
