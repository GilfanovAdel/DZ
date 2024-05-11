using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonApi.DataAccess.Entities
{
    public class PokemonType
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<Pokemon> Pokemons { get; set; }
    }
}
