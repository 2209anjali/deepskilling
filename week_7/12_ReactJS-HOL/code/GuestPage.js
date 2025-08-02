import React from 'react';

const GuestPage = () => {
    return (
        <div>
            <h2>Welcome Guest ✈️</h2>
            <p>You can browse available flights, but need to log in to book tickets.</p>
            <h3>Flight List:</h3>
            <ul>
                <li>IndiGo - BLR to DEL - ₹4500</li>
                <li>Air India - MUM to HYD - ₹4000</li>
                <li>SpiceJet - CHN to BOM - ₹4800</li>
            </ul>
        </div>
    );
};

export default GuestPage;
