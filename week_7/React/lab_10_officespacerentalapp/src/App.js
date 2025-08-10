import React from 'react';
import './App.css';
import sr from './office.jpg'; 

function App() {
  const element = "Office Space";

  const jsxatt = <img src={sr} width="25%" height="25%" alt="Office Space" />;

  const officeList = [
    { Name: "SAVEETHA", Rent: 50000, Address: 'Chennai' }    
  ];

  return (
    <div style={{ padding: "20px" }}>
      <h1>{element} , at Affordable Range</h1>
      {jsxatt}

      <br /><br />
      {officeList.map((office, index) => {
        const rentStyle = {
          color: office.Rent <= 60000 ? "red" : "green"
        };

        return (
          <div key={index}>
            <h2>Name: {office.Name}</h2>
            <h3 style={rentStyle}>Rent: Rs. {office.Rent}</h3>
            <h3>Address: {office.Address}</h3>
            <hr />
          </div>
        );
      })}
    </div>
  );
}

export default App;
