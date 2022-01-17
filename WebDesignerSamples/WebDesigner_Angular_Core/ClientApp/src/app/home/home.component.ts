import { Component, ViewChild, ElementRef, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
declare var GrapeCity: any;
declare var $: any;

var viewer = null;

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})

export class HomeComponent implements OnInit {
  reportName: any;
  @ViewChild('viewer') private viewerElement: ElementRef;

  constructor(private route: ActivatedRoute) {
    this.route.params.subscribe(params => {
      const id = params['id'];
      const designerOptions = GrapeCity.ActiveReports.WebDesigner.createDesignerOptions();
      designerOptions.server.url = 'api';
      designerOptions.reportInfo = id ? { id: id, name: id } : null;
      designerOptions.reportItemsFeatures.table.autoFillFooter = true;
      designerOptions.openButton.visible = true;
      designerOptions.saveButton.visible = true;
      designerOptions.saveAsButton.visible = true;
      designerOptions.documentation.home = 'https://www.grapecity.com/activereports/docs/v16/online-webdesigner/overview.html';
      designerOptions.openViewer = this.openViewer.bind(this);
      designerOptions.dataTab.dataSets.canModify = true;
      designerOptions.dataTab.dataSources.canModify = true;
      GrapeCity.ActiveReports.WebDesigner.renderApplication('designer-id', designerOptions);
    });
  }

  ngOnInit() {}

  public openViewer(options) {
    if (viewer) {
        viewer.openReport(options.reportInfo.id);
        return;
    }
    viewer = GrapeCity.ActiveReports.JSViewer.create({
      locale: 'en',
      element: '#' + options.element,
      reportService: {
        url: 'api/reporting',
      },
      reportID: options.reportInfo.id,
      settings: {
        zoomType: 'FitPage'
      },
    });
  }

  public closeViewer() {
    this.viewerElement.nativeElement.firstElementChild.remove();
  }
}