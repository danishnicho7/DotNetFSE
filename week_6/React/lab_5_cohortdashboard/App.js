import React from 'react';
import CohortDetails from './CohortDetails';

function App() {
  return (
    <div style={{ padding: '20px' }}>
      <h1>Cohort Dashboard</h1>
      <CohortDetails
        cohort={{ name: 'React Basics', status: 'ongoing', startDate: '2025-05-25', endDate: '2025-06-25' }}
      />
      <CohortDetails
        cohort={{ name: 'Advanced Java', status: 'completed', startDate: '2025-04-24', endDate: '2025-05-24' }}
      />
    </div>
  );
}

export default App;
