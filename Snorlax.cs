﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonDex
{
    public class Snorlax : Pokemon
    {
        public Snorlax()
        {
            this.Name = "Snorlax";
            this.Type = PokemonType.Normal;
            this.Type2 = PokemonType.None;
            this.HP = 160;
            this.Attack = 110;
            this.Defense = 65;
            this.SpecialAttack = 65;
            this.SpecialDefense = 110;
            this.Speed = 30;
            this.Total = 540;

            this.image =
                Resource1.ResourceManager.GetObject("Snorlax") as byte[] ?? Array.Empty<byte>();
        }
    }
}
