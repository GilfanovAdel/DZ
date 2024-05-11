using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using PokemonApi.DataAccess.Entities;

namespace PokemonApi.DataAccess.Configurations
{
    public class BreedingConfiguration : IEntityTypeConfiguration<Breeding>
    {
        public void Configure(EntityTypeBuilder<Breeding> builder)
        {
            builder.ToTable("Breedings")
                .HasKey(x => x.Id);

            builder.HasOne(b => b.Pokemon)
                .WithOne(p => p.Breeding)
                .HasForeignKey<Breeding>(b => b.Id);
        }
    }
}
