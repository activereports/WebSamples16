import * as React from "react";
import { ReportsList } from "./reportsList";
import { ReportViewer } from "./reportViewer";
import { ReportProvider, reportContext } from "./reportProvider";

function App() {
  return (
    <div className="main">
      <ReportProvider>
        <ReportsList />
        <reportContext.Consumer>
          {(val) => <ReportViewer reportId={val?.currentReport || ""} />}
        </reportContext.Consumer>
      </ReportProvider>
    </div>
  );
}

export default App;
