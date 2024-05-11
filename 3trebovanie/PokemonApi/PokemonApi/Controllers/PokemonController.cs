using Microsoft.AspNetCore.Mvc;
using PokemonApi.DataAccess;
using Microsoft.EntityFrameworkCore;
using PokemonApi.DataAccess.Entities;
using Application.Exceptions;


namespace PokemonApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public sealed class PokemonController : ControllerBase
    {
        private readonly AppDbContext _context;

        public PokemonController(AppDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Метод для получения всех покемонов
        /// </summary>
        /// <returns>Возвращает список всех покемонов в системе</returns>
        [HttpGet]
        public async Task<IEnumerable<Pokemon>> GetAll()
        {
            return await _context.Pokemons.ToListAsync();
        }

        /// <summary>
        /// Метод для покемонов по указаной строке поиска
        /// </summary>
        /// <returns>Возвращает список всех найденных покенов </returns>

        // TODO: ножно с массивом данных отдавать общее количество фильтрованных данных  (total)


        [HttpGet("GetByFilter")]
        public async Task<IEnumerable<object>> GetByFilter([FromQuery] string? name)
        {
            var result = await _context.Pokemons.ToListAsync();
            return result.Where(p => p.Name.Contains(name, StringComparison.OrdinalIgnoreCase))
                .Select(p => new { p.Id, p.Name });
        }


        /// <summary>
        /// Метод для получения всей информации по одному покемону
        /// </summary>
        /// <returns>Возвращает полную информацию о покемоне по заданному Id или Name </returns>
        [HttpGet("NameOrId")]
        public Pokemon GetByIdOrName([FromQuery] string nameOrId)
        {
            int id = 0;
            if (int.TryParse(nameOrId, out id))
            {
                var result= _context.Pokemons.FirstOrDefault(p => p.Id == id);
                if (result is null)
                {
                    throw new ConflictException("покемона с таким id не существует ");
                }
                return result;
            }
            else
            {
                var result = _context.Pokemons.FirstOrDefault(p => p.Name.ToLower() == nameOrId.ToLower());
                if (result is null)
                {
                    throw new ConflictException("покемона с таким именем не существует ");
                }
                return result;
            }
        }
    }
}