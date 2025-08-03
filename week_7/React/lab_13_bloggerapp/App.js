import React from 'react';
import './App.css';
import CourseDetails from './CourseDetails';
import BookDetails from './BookDetails';
import BlogDetails from './BlogDetails';

function App() {
  const books = [
    { id: 1, bname: "Master React", price: 670 },
    { id: 2, bname: "Deep Dive into Angular 11", price: 800 },
    { id: 3, bname: "Mongo Essentials", price: 450 }
  ];

  const displayBlog = true;

  return (
    <div style={{ display: 'flex', justifyContent: 'space-around' }}>
      <CourseDetails />
      <BookDetails books={books} />
      <BlogDetails showBlog={displayBlog} />
    </div>
  );
}

export default App;
