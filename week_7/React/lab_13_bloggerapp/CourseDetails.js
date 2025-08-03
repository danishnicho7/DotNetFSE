import React from 'react';

const CourseDetails = () => {
  const showReact = true;
  return (
    <div>
      <h2>Course Details</h2>
      <h3>Angular</h3>
      <p>4/5/2021</p>
      {showReact && (
        <>
          <h3>React</h3>
          <p>6/3/20201</p>
        </>
      )}
    </div>
  );
};

export default CourseDetails;
