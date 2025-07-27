import React from 'react';
import CohortDetails from './Components/CohortDetails';
import styles from './Components/CohortDetails.module.css';

function App() {
  return (
    <div>
      <h2 className={styles.title}>Cohorts Details</h2>
      <div className={styles.container}>
        <CohortDetails
          name="INTADMDF10 - .NET FSD"
          status="Scheduled"
          startDate="2022-02-22"
          coach="Aathma"
          trainer="Jojo Jose"
        />
        <CohortDetails
          name="ADM21JF014 - Java FSD"
          status="Ongoing"
          startDate="2021-09-10"
          coach="Apoorv"
          trainer="Elisa Smith"
        />
        <CohortDetails
          name="CDBJF21025 - Java FSD"
          status="Ongoing"
          startDate="2021-12-24"
          coach="Aathma"
          trainer="John Doe"
        />
      </div>
    </div>
  );
}

export default App;
