import React from 'react';

const BlogDetails = ({ showBlog }) => {
  if (!showBlog) return null;

  return (
    <div>
      <h2>Blog Details</h2>
      <h3>React Learning</h3>
      <b>Stephen Biz</b>
      <p>Welcome to learning React!</p>

      <h3>Installation</h3>
      <b>Schwezdenier</b>
      <p>You can install React from npm.</p>
    </div>
  );
};

export default BlogDetails;
