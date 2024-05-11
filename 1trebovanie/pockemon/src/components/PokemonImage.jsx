import React, { useState, useEffect } from 'react';
import '../App.css';
import '../PokeTypes.css';

function PokemonArtwork({ pokemonId }) {
  const [pokemonArtworkUrl, setPokemonArtworkUrl] = useState(null);

  useEffect(() => {
    async function fetchPokemonData() {
      try {
        const response = await fetch(`https://pokeapi.co/api/v2/pokemon/${pokemonId}`);
        const data = await response.json();
        const artworkUrl = data.sprites.other['official-artwork'].front_default;
        setPokemonArtworkUrl(artworkUrl);
      } catch (error) {
        console.error('Error fetching Pokemon data:', error);
      }
    }

    fetchPokemonData();
  }, [pokemonId]);

  return (
    <div>
      {pokemonArtworkUrl ? (
        <img src={pokemonArtworkUrl} alt={`Pokemon ${pokemonId} artwork`} className='poke-img'/>
      ) : (
        <p>Loading...</p>
      )}
    </div>
  );
}

export default PokemonArtwork;