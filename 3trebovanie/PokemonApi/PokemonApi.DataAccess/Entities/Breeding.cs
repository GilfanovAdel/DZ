using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonApi.DataAccess.Entities
{
    public class Breeding
    {
        [Key]
        [ForeignKey("Pokemon")]
        public int Id { get; set; }

        public int Weight { get; set; }

        public int Height { get; set; }

        public Pokemon Pokemon { get; set; }
    }
}
