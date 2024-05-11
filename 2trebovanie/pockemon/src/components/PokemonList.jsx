import PokemonArtwork from './PokemonImage';
import PokemonTypes from './PokemonTypes';
import PokemonInfo from '../components/PokemonInfo';
import React from 'react';
import { Link } from 'react-router-dom';
import '../App.css';
import '../PokeTypes.css';

function Poke({ pokemonList, filteredPokemon }) {
  return (
    <div>
      <div id="poke-container">
        {filteredPokemon ? (
          filteredPokemon.map(pokemon => (
            <Link key={pokemon.id} to={`/pokemon/${pokemon.id}`} className="ui-card">
              <div>
                <p className='poke-name'>{pokemon.name}</p>
                <p className='poke-id'>#{pokemon.id}</p>
                <PokemonArtwork pokemonId={pokemon.id} />
                <PokemonTypes types={pokemon.types} />
              </div>
            </Link>
          ))
        ) : (
          pokemonList.map(pokemon => (
            <Link key={pokemon.url} to={`/pokemon/${pokemon.url.split('/').slice(-2, -1)}`} className="ui-card">
              <div>
                <p className='poke-name'>{pokemon.name}</p>
                <PokemonInfo url={pokemon.url} />
              </div>
            </Link>
          ))
        )}
      </div>
    </div>
  );
}

export default Poke;