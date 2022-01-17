import Vue from 'vue';
import App from './app/App.vue';
import "@grapecity/ar-viewer/dist/jsViewer.min.js";
import "@grapecity/ar-viewer/dist/jsViewer.min.css";

new Vue({
  el: '#app',
  render: h => h(App)
});