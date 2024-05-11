using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonApi.DataAccess.Entities
{
    public class Pokemon
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public int Hp { get; set; }

        public int Attack { get; set; }

        public int Defense { get; set; }

        public int Speed { get; set; }

        public Breeding Breeding { get; set; }

        public List<PokemonType> PokemonTypes { get; set; }
    }
}
