import React from 'react';
import '../App.css';
import '../PokeTypes.css';

function PokemonTypes({ types }) {
  return (
    <ul className='types'>
      {types.map((type, index) => (
        <li 
        key={index} 
        className={`type-card ${type.type.name}`}>
          {type.type.name}
          </li>
      ))}
    </ul>
  );
}

export default PokemonTypes;