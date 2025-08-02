// src/register.js
import React, { useState } from 'react';

const Register = () => {
    const [form, setForm] = useState({
        name: '',
        email: '',
        password: ''
    });

    const [errors, setErrors] = useState({});

    const validate = () => {
        const newErrors = {};

        if (form.name.trim().length < 5) {
            newErrors.name = 'Name must be at least 5 characters long';
        }

        if (!form.email.includes('@') || !form.email.includes('.')) {
            newErrors.email = 'Email must contain "@" and "."';
        }

        if (form.password.length < 8) {
            newErrors.password = 'Password must be at least 8 characters';
        }

        return newErrors;
    };

    const handleChange = (e) => {
        const { name, value } = e.target;
        setForm({ ...form, [name]: value });
    };

    const handleSubmit = (e) => {
        e.preventDefault();
        const validationErrors = validate();

        if (Object.keys(validationErrors).length === 0) {
            alert('Form submitted successfully!');
            // Clear the form
            setForm({ name: '', email: '', password: '' });
        } else {
            setErrors(validationErrors);
        }
    };

    return (
        <div style={{ padding: '20px' }}>
            <h2>Mail Register Form</h2>
            <form onSubmit={handleSubmit} noValidate>
                <div>
                    <label>Name:</label><br />
                    <input
                        type="text"
                        name="name"
                        value={form.name}
                        onChange={handleChange}
                        required
                    />
                    <div style={{ color: 'red' }}>{errors.name}</div>
                </div>
                <br />

                <div>
                    <label>Email:</label><br />
                    <input
                        type="email"
                        name="email"
                        value={form.email}
                        onChange={handleChange}
                        required
                    />
                    <div style={{ color: 'red' }}>{errors.email}</div>
                </div>
                <br />

                <div>
                    <label>Password:</label><br />
                    <input
                        type="password"
                        name="password"
                        value={form.password}
                        onChange={handleChange}
                        required
                    />
                    <div style={{ color: 'red' }}>{errors.password}</div>
                </div>
                <br />

                <button type="submit">Register</button>
            </form>
        </div>
    );
};

export default Register;
