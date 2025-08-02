import React from 'react';
import officeImage from './office.png';

function App() {
    // Office object
    const office = {
        name: "Orchid Tech Park",
        rent: 75000,
        address: "Whitefield, Bangalore"
    };

    // Office list
    const officeList = [
        {
            name: "Tech Hub A",
            rent: 45000,
            address: "HSR Layout"
        },
        {
            name: "SmartSpace B",
            rent: 68000,
            address: "Koramangala"
        },
        {
            name: "WorkNest C",
            rent: 58000,
            address: "Indiranagar"
        },
        {
            name: "UrbanDesk D",
            rent: 85000,
            address: "MG Road"
        }
    ];

    // Style generator based on rent value
    const getRentStyle = (rent) => ({
        color: rent < 60000 ? 'red' : 'green',
        fontWeight: 'bold'
    });

    return (
        <div style={{ padding: '20px', fontFamily: 'Arial' }}>
            {/* JSX Heading */}
            <h1>🏢 Office Space Rental App</h1>

            {/* JSX Image with Attribute */}
            <img
                src={officeImage}
                alt="Office Space"
                style={{ width: '300px', borderRadius: '10px' }}
            />

            <h2>Featured Office:</h2>
            <p><strong>Name:</strong> {office.name}</p>
            <p><strong>Address:</strong> {office.address}</p>
            <p><strong>Rent:</strong> <span style={getRentStyle(office.rent)}>₹{office.rent}</span></p>

            <hr />

            <h2>Other Office Spaces</h2>
            {officeList.map((o, index) => (
                <div key={index} style={{ marginBottom: '20px' }}>
                    <p><strong>Name:</strong> {o.name}</p>
                    <p><strong>Address:</strong> {o.address}</p>
                    <p><strong>Rent:</strong> <span style={getRentStyle(o.rent)}>₹{o.rent}</span></p>
                    <hr />
                </div>
            ))}
        </div>
    );
}

export default App;
