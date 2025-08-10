import React from 'react';
import ListofPlayers from './ListofPlayers';
import Scorebelow70 from './Scorebelow70';
import OddPlayers from './OddPlayers';
import EvenPlayers from './EvenPlayers';
import ListofIndianPlayers from './ListofIndianPlayers';

function App() {
  const flag = false;

  const players = [
    { name: "Rohit", score: 80 },
    { name: "Virat", score: 65 },
    { name: "Rahul", score: 50 },
    { name: "Shreyas", score: 90 },
    { name: "Jadeja", score: 45 },
    { name: "Hardik", score: 75 },
    { name: "Surya", score: 30 },
    { name: "Gill", score: 95 },
    { name: "Shami", score: 55 },
    { name: "Bumrah", score: 88 },
    { name: "Kuldeep", score: 66 },
  ];

  const IndianTeam = ["Rohit", "Virat", "Rahul", "Hardik", "Jadeja", "Bumrah", "Shami", "Gill", "Surya", "Kuldeep", "Shreyas"];

  const T20players = ["Rohit", "Surya", "Gill"];
  const RanjiPlayers = ["Rahul", "Kuldeep", "Jadeja"];

  const IndianPlayers = [...T20players, ...RanjiPlayers];

  if (flag === true) {
    return (
      <div>
        <h1>List of Players</h1>
        <ListofPlayers players={players} />
        <hr />
        <h1>List of Players having Scores Less than 70</h1>
        <Scorebelow70 players={players} />
      </div>
    );
  } else {
    return (
      <div>
        <div>
          <h1>Indian Team</h1>
          <h1>Odd Players</h1>
          <OddPlayers team={IndianTeam} />
          <hr />
          <h1>Even Players</h1>
          <EvenPlayers team={IndianTeam} />
        </div>
        <hr />
        <div>
          <h1>List of Indian Players Merged:</h1>
          <ListofIndianPlayers IndianPlayers={IndianPlayers} />
        </div>
      </div>
    );
  }
}

export default App;
