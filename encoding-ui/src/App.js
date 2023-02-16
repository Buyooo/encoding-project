import './encoding';
import './App.css';

function App() {
  return (
    <div className="App">
      <h1>Encoding UI</h1>

      <label>Encode string:</label>

      <div>
        <input type='text' id='input-encoding'>
        </input>

        <button id='encode-button'>Encode this string</button>

        <br />

        <label>Encoded string response:</label>
        <input type='textbox' id='output-encoding' size='500'>
        </input>
      </div>

    </div>
  );
}

export default App;
