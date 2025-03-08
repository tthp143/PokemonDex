using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonDex
{
    public class Rookidee : Pokemon
    {
        public Rookidee()
        {
            this.Name = "Rookidee";
            this.Type = PokemonType.Flying;
            this.Type2 = PokemonType.None;
            this.HP = 38;
            this.Attack = 47;
            this.Defense = 35;
            this.SpecialAttack = 33;
            this.SpecialDefense = 35;
            this.Speed = 57;
            this.Total = 245;

            this.image =
                Resource1.ResourceManager.GetObject("Rookidee") as byte[] ?? Array.Empty<byte>();
        }
    }
}
