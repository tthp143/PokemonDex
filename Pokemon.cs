using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonDex
{
    public enum PokemonType
    {
        None,
        Normal,
        Flying,
        Electric,
        Fire,
        Psychic
        


    }
    public class Pokemon
    {
        public string Name;
        public int HP;
        public int Attack;
        public int Defense;
        public int SpecialAttack;
        public int SpecialDefense;
        public int Speed;
        public int Total;
        public PokemonType Type;
        public PokemonType Type2;
        public byte[] image;
        //contructor
        public Pokemon() { }
        //method
        public string getName()
        {
            return this.Name;
        }
        public byte[] getImage()
        {
            return this.image;
        }
    }
}
