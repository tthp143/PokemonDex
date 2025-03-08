using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PokemonDex
{
    public class Charizard : Pokemon
    {
        public Charizard()
        {
            this.Name = "Charizard";
            this.Type = PokemonType.Fire;
            this.Type2 = PokemonType.Flying;
            this.HP = 78;
            this.Attack = 84;
            this.Defense = 78;
            this.SpecialAttack = 109;
            this.SpecialDefense = 85;
            this.Speed = 100;
            this.Total = 534;

            this.image =
                Resource1.ResourceManager.GetObject("Charizard") as byte[] ?? Array.Empty<byte>();
        }
    }
}
