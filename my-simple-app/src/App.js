import './App.css';
import FirstComponent from './components/FirstComponent.js'
import TemplateExpression from './components/TemplateExpression.js'
import MyComponent from './components/MyComponent.js';
import Event from './components/Event.js'
import Challenge from './components/Challenge.js';

function App() {
  return (
    <div className="App">
      <h1>Fundamentos do React</h1>
      <FirstComponent />
      <TemplateExpression />
      <MyComponent />
      <Event />
      <Challenge numero1={2} numero2={3} />
      <p className="Copy">Desenvolvido por Rafael &copy; 2025</p>
    </div>
  );
}

export default App;
