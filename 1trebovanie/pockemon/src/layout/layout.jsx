import React from "react";
import { BrowserRouter as Router, Route, Routes } from 'react-router-dom';
import MainPage from "../pages/MainPage";
import PokemonCard from "../components/Pokemon";
import '../App.css';
import '../PokeTypes.css';


const Layout = () => {
    return (
        <div>
            <header></header>
            <main>
                <div className="wrapper">
                    <Routes>
                        <Route exact path="/" element={<MainPage />} />
                        <Route path="/pokemon/:id" element={<PokemonCard />} />
                    </Routes>
                </div>
            </main>
        </div>
    );
}

export default Layout;