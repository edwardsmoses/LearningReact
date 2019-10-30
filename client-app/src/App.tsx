import React from 'react';
import logo from './logo.svg';
import './App.css';
import { cars } from './demo';
import CarItem from './CarItem';


const App: React.FC = () => {
  return (
    <div className="App">
      <header className="App-header">
        <p>
          Learning React. <small>30. October 2019.</small>
        </p>

        <ul>
          {
            cars.map((car) => (
              <CarItem car={car}></CarItem>
            ))
          }
        </ul>
      
      </header>
    </div>
    
  );
}

export default App;
