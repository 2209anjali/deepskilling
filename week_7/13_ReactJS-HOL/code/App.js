import React, { useState } from 'react';
import BookDetails from './BookDetails';
import BlogDetails from './BlogDetails';
import CourseDetails from './CourseDetails';

function App() {
    const [active, setActive] = useState('book'); // 'book' | 'blog' | 'course'

    return (
        <div style={{ padding: '20px', fontFamily: 'Arial' }}>
            <h1>📚 Blogger App - Conditional Rendering</h1>

            <div style={{ marginBottom: '20px' }}>
                <button onClick={() => setActive('book')}>Show Book</button>{' '}
                <button onClick={() => setActive('blog')}>Show Blog</button>{' '}
                <button onClick={() => setActive('course')}>Show Course</button>
            </div>

            {/* Method 1: if-else rendering */}
            {active === 'book' && <BookDetails />}

            {/* Method 2: Ternary rendering */}
            {active === 'blog'
                ? <BlogDetails />
                : active === 'course'
                    ? <CourseDetails />
                    : null}

            {/* Method 3: Switch-case rendering */}
            {/* Could also be separated to a renderComponent() function */}
        </div>
    );
}

export default App;
