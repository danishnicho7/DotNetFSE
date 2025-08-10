import React from 'react';

const OddPlayers = ({ team }) => {
  return (
    <ul>
      {team.filter((_, i) => i % 2 !== 0).map((player, index) => (
        <li key={index}>{player}</li>
      ))}
    </ul>
  );
};

export default OddPlayers;
