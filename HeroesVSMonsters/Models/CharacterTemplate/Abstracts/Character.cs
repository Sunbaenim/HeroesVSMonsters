using HeroesVSMonsters.Models.DiceTemplate;
using HeroesVSMonsters.Models.MapTemplate;
using HeroesVSMonsters.Models.CharacterTemplate.Heroes.Concrete;
using HeroesVSMonsters.Models.CharacterTemplate.Monsters.Concrete;

namespace HeroesVSMonsters.Models.CharacterTemplate.Abstracts
{
    public abstract class Character
    {
        protected Dice _d6;
        protected Dice _d4;
        private short _healthPoints;
        public string CharactersName { get; }
        public Map MapName { get; }
        public ushort Stamina { get; }
        public ushort StaminaBonus { get; } = 0;
        public ushort Strength { get; }
        public ushort StrengthBonus { get; } = 0;
        public short HealthPoints
        {
            get { return _healthPoints; }
            private set { _healthPoints = value; }
        }
        public Character(string charactersName, Map mapName)
        {
            switch (this)
            {
                case Human human:
                    StaminaBonus = 1;
                    StrengthBonus = 1;
                    break;
                case Dwarf dwarf:
                    StaminaBonus = 2;
                    break;
                case Dragonet dragonet:
                    StaminaBonus = 1;
                    break;
                case Orc orc:
                    StrengthBonus = 1;
                    break;
                default:
                    break;
            }
            MapName = mapName;
            CharactersName = charactersName;
            MapName.CharactersList.Add(this);
            _d6 = new Dice(6);
            _d4 = new Dice(4);
            Stamina = _d6.ThrowDices(4, 3);
            Strength = _d6.ThrowDices(4, 3);
            HealthPoints = (short)(Stamina + ((Stamina + StaminaBonus < 5) ? -1 : (Stamina + StaminaBonus < 10) ? 0 : (Stamina + StaminaBonus < 15) ? 1 : 2));
        }
        public virtual void Strike(Character target)
        {
            target.HealthPoints -= (short)(_d4.ThrowDices() + ((Strength + StrengthBonus < 5) ? -1 : (Strength + StrengthBonus < 10) ? 0 : (Strength + StrengthBonus < 15) ? 1 : 2));
        }
    }
}
