using System;
using System.Linq;

namespace HeroesVSMonsters.Models.DiceTemplate
{
    public class Dice
    {
        private readonly Random _random;
        public byte NbSide { get; }
        public Dice(byte nbSides)
        {
            _random = new Random();
            NbSide = nbSides;
        }
        public byte ThrowDices(byte nbRolls = 1, byte keep = 1)
        {
            if (nbRolls == 1) return (byte)_random.Next(1, NbSide + 1);

            int[] arrayRolls = new int[nbRolls];
            for (byte i = 0; i < nbRolls; i++)
            {
                arrayRolls[i] = (byte)_random.Next(1, NbSide + 1);
            }
            return (byte)arrayRolls.OrderByDescending(it => it).Take(keep).Sum();
        }
    }
}
