import './App.css';
import './PokeTypes.css';
import React from 'react';
import { BrowserRouter as Router } from 'react-router-dom';
import Layout from './layout/layout';


function App() {
  return(
    <Router>
      <div>
        <header></header>
        <main>
          <div className="wrapper">
            <Layout />
          </div>
        </main>
      </div>
    </Router>
  );
}

export default App;
