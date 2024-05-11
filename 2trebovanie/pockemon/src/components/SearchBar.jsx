import React, { useState } from 'react';
import '../App.css';
import '../PokeTypes.css';

function SearchBar({ onSearch }) {
  const [searchTerm, setSearchTerm] = useState('');

  const handleChange = (event) => {
    setSearchTerm(event.target.value);
  };

  const handleSubmit = (event) => {
    event.preventDefault();
    onSearch(searchTerm);
  };

  return (
    <form onSubmit={handleSubmit} className="search-bar">
      <input
        type="text"
        placeholder="E.g. Pikachu"
        value={searchTerm}
        onChange={handleChange}
        className="search-bar-input"
      />
      <button type="submit" className="search-bar-button">GO</button>
    </form>
  );
}

export default SearchBar;