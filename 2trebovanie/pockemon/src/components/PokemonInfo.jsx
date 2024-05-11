import PokemonTypes from './PokemonTypes';
import PokemonArtwork from './PokemonImage';
import React, { useState, useEffect } from 'react';
import '../App.css';
import '../PokeTypes.css';

function PokemonInfo({ url }) {
  const [pokemonInfo, setPokemonInfo] = useState(null);

  useEffect(() => {
    async function fetchPokemonInfo() {
      try {
        const response = await fetch(url);
        const data = await response.json();
        setPokemonInfo(data);
      } catch (error) {
        console.error('Error fetching Pokemon info:', error);
      }
    }

    fetchPokemonInfo();
  }, [url]);

  return (
    <div>
      {pokemonInfo && (
        <>
          <p className='poke-id'>#{pokemonInfo.id}</p>
          <PokemonArtwork pokemonId={pokemonInfo.id} />
          <PokemonTypes types={pokemonInfo.types} />
        </>
      )}
    </div>
  );
}

export default PokemonInfo;