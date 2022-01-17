import * as React from 'react';
import * as ReactDOM from 'react-dom';
import App from './App';
import './index.css';
import "@grapecity/ar-viewer/dist/jsViewer.min.js";
import "@grapecity/ar-viewer/dist/jsViewer.min.css";


ReactDOM.render(
  <React.StrictMode>
    <App />
  </React.StrictMode>,
  document.getElementById('root')
);