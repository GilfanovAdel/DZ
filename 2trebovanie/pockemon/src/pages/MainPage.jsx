import React, { useState, useEffect } from 'react';
import SearchBar from '../components/SearchBar';
import Poke from '../components/PokemonList';
import '../App.css';
import '../PokeTypes.css';

function MainPage() {
  const [pokemonList, setPokemonList] = useState([]);
  const [filteredPokemon, setFilteredPokemon] = useState(null);
  const [searchError, setSearchError] = useState(false);

  useEffect(() => {
    fetch('https://pokeapi.co/api/v2/pokemon?limit=150')
      .then(response => response.json())
      .then(function (allpokemon) {
        setPokemonList(allpokemon.results);
      });
  }, []);

  const handleSearch = async (searchTerm) => {
    if (searchTerm.trim() === '') {
      setFilteredPokemon(null);
      setSearchError(false);
    } else {
      try {
        const regex = new RegExp(`^${searchTerm.toLowerCase()}`);
        const filteredList = pokemonList.filter(pokemon => regex.test(pokemon.name));
        if (filteredList.length > 0) {
          const pokemonData = await Promise.all(filteredList.map(async (pokemon) => {
            const response = await fetch(pokemon.url);
            return response.json();
          }));
          setFilteredPokemon(pokemonData);
          setSearchError(false);
        } else {
          setFilteredPokemon(null);
          setSearchError(true);
        }
      } catch (error) {
        console.error('Error searching for Pokemon:', error);
        setSearchError(true);
      }
    }
  };

  return (
    <div className="app">
      <div className='head'>
        <h1 className='main-name'>Who are you looking for?</h1>
        <SearchBar onSearch={handleSearch} />
      </div>
      {searchError ? 
      <div>
        <h3 className='error'>Oops! Try again.</h3>
        <p className='error'>The Pokemon you're looking for is a unicorn. It doesn't exist in this list.</p>
        <img src='https://projectpokemon.org/images/sprites-models/homeimg/poke_capture_0025_001_mo_n_00000000_f_n.png' className='img-error' />
      </div>
      : <Poke pokemonList={pokemonList} filteredPokemon={filteredPokemon} />}
    </div>
  );
}

export default MainPage;