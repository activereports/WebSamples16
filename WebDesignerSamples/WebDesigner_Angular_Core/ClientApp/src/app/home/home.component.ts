import { Component, ViewChild, ElementRef, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
declare var GrapeCity: any;
declare var $: any;

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})

export class HomeComponent implements OnInit {
    private viewer: any;

    constructor(private route: ActivatedRoute) { }

    ngOnInit() {
        GrapeCity.ActiveReports.Designer.create('#ar-web-designer', {
            rpx: { enabled: true },
            appBar: { openButton: { visible: true } },
            data: { dataSets: { canModify: true }, dataSources: { canModify: true } },
            preview: {
                openViewer: (options) => {
                    if (this.viewer) {
                        this.viewer.openReport(options.documentInfo.id);
                        return;
                    }
                    this.viewer = GrapeCity.ActiveReports.JSViewer.create({
                        element: '#' + options.element,
                        renderFormat: 'svg',
                        reportService: {
                            url: 'api/reporting',
                        },
                        reportID: options.documentInfo.id,
                        settings: {
                            zoomType: 'FitPage',
                        },
                    });
                }
            }
        });
    }

    ngOnDestroy() {
        this.viewer.destroy();
	}
}