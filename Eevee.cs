using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonDex
{
    public class Eevee : Pokemon
    {
        public Eevee()
        {
            this.Name = "Eevee";
            this.Type = PokemonType.Normal;
            this.Type2 = PokemonType.None;
            this.HP = 55;
            this.Attack = 55;
            this.Defense = 50;
            this.SpecialAttack = 45;
            this.SpecialDefense = 65;
            this.Speed = 55;
            this.Total = 325;

            this.image =
                Resource1.ResourceManager.GetObject("Eevee") as byte[] ?? Array.Empty<byte>();
        }
    }
}
