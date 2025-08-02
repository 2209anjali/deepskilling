// src/EmployeeCard.js
import React, { useContext } from 'react';
import ThemeContext from './ThemeContext';

const EmployeeCard = ({ employee }) => {
    const theme = useContext(ThemeContext);

    const buttonStyle = {
        padding: '10px',
        margin: '10px 0',
        color: theme === 'light' ? '#000' : '#fff',
        backgroundColor: theme === 'light' ? '#eee' : '#333',
        border: '1px solid #ccc',
        borderRadius: '5px'
    };

    return (
        <div style={{ border: '1px solid #ccc', padding: '10px', marginBottom: '10px' }}>
            <h3>{employee.name}</h3>
            <p>{employee.position}</p>
            <button style={buttonStyle}>Message</button>
        </div>
    );
};

export default EmployeeCard;
