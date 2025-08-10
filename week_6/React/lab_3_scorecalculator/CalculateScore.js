import React from 'react';
import '../Stylesheets/mystyle.css';

function CalculateScore() {
  const name = "Danish Nicho";
  const school = "Saint Assisi Matric Hr. Sec. School";
  const total = 498;
  const goal = 500;

  const average = ((total / goal) * 100).toFixed(2);

  return (
    <div className="score-container">
      <h2>Student Score Calculator</h2>
      <p><strong>Name:</strong> {name}</p>
      <p><strong>School:</strong> {school}</p>
      <p><strong>Total Score:</strong> {total}</p>
      <p><strong>Goal Score:</strong> {goal}</p>
      <p><strong>Average Score:</strong> {average}%</p>
    </div>
  );
}

export default CalculateScore;
