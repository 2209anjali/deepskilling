// src/IndianPlayers.js
import React from 'react';

const IndianPlayers = () => {
    const T20players = ['Rohit', 'Surya', 'Pant', 'Hardik', 'Bumrah'];
    const RanjiTrophyPlayers = ['Pujara', 'Rahane', 'Jadeja', 'Ashwin', 'Shami'];

    // Merge arrays using ES6 spread operator
    const allPlayers = [...T20players, ...RanjiTrophyPlayers];

    // Destructure players into odd and even
    const oddPlayers = allPlayers.filter((_, i) => i % 2 !== 0);
    const evenPlayers = allPlayers.filter((_, i) => i % 2 === 0);

    return (
        <div>
            <h2>Indian Players</h2>
            <h3>Even Team</h3>
            <ul>
                {evenPlayers.map((player, index) => (
                    <li key={index}>{player}</li>
                ))}
            </ul>
            <h3>Odd Team</h3>
            <ul>
                {oddPlayers.map((player, index) => (
                    <li key={index}>{player}</li>
                ))}
            </ul>
        </div>
    );
};

export default IndianPlayers;
