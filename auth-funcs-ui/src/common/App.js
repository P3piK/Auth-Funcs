import React from 'react'
import { BrowserRouter, Navigate, Route, Routes } from 'react-router-dom';
import Gallery from '../gallery/Gallery';
import Home from '../home/Home';

function App() {
  return <BrowserRouter>
      <Routes>
          <Route exact path='/' element={<Home />} />
          <Route exact path='/gallery' element={<Gallery />} />    
          <Route path="*" element={<Navigate to="/" replace />} />
      </Routes>
    </BrowserRouter>;
}

export default App;