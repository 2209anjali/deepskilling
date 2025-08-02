// src/App.js
import React, { useState } from 'react';
import EmployeesList from './EmployeesList';
import ThemeContext from './ThemeContext';

function App() {
    const [theme, setTheme] = useState('light');

    const toggleTheme = () => setTheme(theme === 'light' ? 'dark' : 'light');

    return (
        <ThemeContext.Provider value={theme}>
            <div>
                <h1>Employee Management App</h1>
                <button onClick={toggleTheme}>
                    Toggle Theme (Current: {theme})
                </button>

                {/* No need to pass theme as prop anymore */}
                <EmployeesList />
            </div>
        </ThemeContext.Provider>
    );
}

export default App;
