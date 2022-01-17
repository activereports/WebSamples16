import { Component, Input, ViewEncapsulation } from '@angular/core';
declare var GrapeCity: any;

@Component({
  selector: 'report-viewer',
  templateUrl: './report-viewer.component.html',
  styleUrls: ['./report-viewer.component.css'],
  encapsulation: ViewEncapsulation.None,
})
export class ReportViewerComponent {
  private viewer: any;

  @Input() set reportId(reportId: string) {
      if (!this.viewer) {
          this.viewer = GrapeCity.ActiveReports.JSViewer.create({
              element: '#viewerPlaceHolder'
          });
      }

      this.viewer.openReport(reportId);
  }
}
