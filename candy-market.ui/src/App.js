import React from 'react';

import './App.css';
import Candy from './components/candy/Candy';

class App extends React.Component {
  render() {
      return (
      <div className="App">
        <header className="CandyMarket">
         
          
          <Candy/>
        </header>
      </div>
    );
  }
}

export default App;