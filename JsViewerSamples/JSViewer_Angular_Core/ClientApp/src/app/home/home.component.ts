import { Component } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent {
  public Hello: string;
  public Wellcome: string;
  public Select: string;

  constructor() {
    if (navigator.language === 'ja') {
      this.Hello = 'こんにちは、お客様！';
      this.Wellcome = 'AngularアプリケーションのJS Viewerへようこそ';
      this.Select = 'プレビューするには、左側のパネルからレポートを選択してください。';
    } else {
      this.Hello = 'Hello, Customer!';
      this.Wellcome = 'Welcome to the JS Viewer in an Angular application';
      this.Select = 'Please select a report from the left panel to preview it.';
    }
  }
}
