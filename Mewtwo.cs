using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonDex
{
    public class Mewtwo : Pokemon
    {
        public Mewtwo()
        {
            this.Name = "Mewtwo";
            this.Type = PokemonType.Psychic;
            this.Type2 = PokemonType.None;
            this.HP = 106;
            this.Attack = 110;
            this.Defense = 90;
            this.SpecialAttack = 154;
            this.SpecialDefense = 90;
            this.Speed = 130;
            this.Total = 680;

            this.image =
                Resource1.ResourceManager.GetObject("Mewtwo") as byte[] ?? Array.Empty<byte>();
        }
    }
}
