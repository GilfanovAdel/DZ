using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PokemonApi.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonApi.DataAccess.Configurations
{
    public class PokemonConfiguration : IEntityTypeConfiguration<Pokemon>
    {
        public void Configure(EntityTypeBuilder<Pokemon> builder)
        {
            builder.ToTable("Pokemons")
                .HasKey(x => x.Id);

            builder.Property(p => p.Name)
                .IsRequired();
                

            builder.HasOne(p => p.Breeding)
                .WithOne(b => b.Pokemon)
                .HasForeignKey<Breeding>(b => b.Id);

            builder.HasMany(p => p.PokemonTypes)
                .WithMany(pt => pt.Pokemons)
                .UsingEntity(j => j.ToTable("PokemonPokemonTypes"));
        }
    }
}
