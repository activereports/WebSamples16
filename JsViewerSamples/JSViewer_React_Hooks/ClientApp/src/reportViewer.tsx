import * as React from "react";

interface ARViewer{
    openReport: (id:string)=>void;
}

export const ReportViewer: React.FC<{ reportId: string }> = ({ reportId }) => {
  const [viewerInstance, setViewerInstance] = React.useState<ARViewer | undefined>(undefined);
  React.useEffect(() => {
    if (!viewerInstance) {
      const viewer = (window as any).GrapeCity.ActiveReports.JSViewer.create({
        element: "#viewerContainer",
      });
      setViewerInstance(viewer);
    }
    if (reportId) {
      viewerInstance?.openReport(reportId);
    }
    // eslint-disable-next-line react-hooks/exhaustive-deps
  }, [reportId]);
  return <div id="viewerContainer" />;
};
