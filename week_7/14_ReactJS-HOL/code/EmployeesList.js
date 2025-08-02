// src/EmployeesList.js
import React from 'react';
import EmployeeCard from './EmployeeCard';

const EmployeesList = () => {
    const employees = [
        { name: 'Anjali', position: 'Frontend Developer' },
        { name: 'Ravi', position: 'Backend Developer' },
        { name: 'Sara', position: 'UI/UX Designer' },
    ];

    return (
        <div>
            <h2>Employees List</h2>
            {employees.map((emp, index) => (
                <EmployeeCard key={index} employee={emp} />
            ))}
        </div>
    );
};

export default EmployeesList;
