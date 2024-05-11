using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace PokemonApi.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pokemons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Hp = table.Column<int>(type: "integer", nullable: false),
                    Attack = table.Column<int>(type: "integer", nullable: false),
                    Defense = table.Column<int>(type: "integer", nullable: false),
                    Speed = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pokemons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PokemonTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokemonTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Breedings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false),
                    Weight = table.Column<int>(type: "integer", nullable: false),
                    Height = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Breedings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Breedings_Pokemons_Id",
                        column: x => x.Id,
                        principalTable: "Pokemons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PokemonPokemonTypes",
                columns: table => new
                {
                    PokemonTypesId = table.Column<int>(type: "integer", nullable: false),
                    PokemonsId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokemonPokemonTypes", x => new { x.PokemonTypesId, x.PokemonsId });
                    table.ForeignKey(
                        name: "FK_PokemonPokemonTypes_PokemonTypes_PokemonTypesId",
                        column: x => x.PokemonTypesId,
                        principalTable: "PokemonTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PokemonPokemonTypes_Pokemons_PokemonsId",
                        column: x => x.PokemonsId,
                        principalTable: "Pokemons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PokemonPokemonTypes_PokemonsId",
                table: "PokemonPokemonTypes",
                column: "PokemonsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Breedings");

            migrationBuilder.DropTable(
                name: "PokemonPokemonTypes");

            migrationBuilder.DropTable(
                name: "PokemonTypes");

            migrationBuilder.DropTable(
                name: "Pokemons");
        }
    }
}
