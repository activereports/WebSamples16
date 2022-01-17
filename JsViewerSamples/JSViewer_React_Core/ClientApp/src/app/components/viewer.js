import React, {Component} from "react";

export default class Viewer extends Component {
    constructor(props) {
        super(props);
    }

    componentDidMount() {
        this.viewer = GrapeCity.ActiveReports.JSViewer.create({
            element: '#viewerContainer'
        });
    }

    componentDidUpdate() {
        this.viewer.openReport(this.props.reportName);
    }

    render() {
        return (
            <div>
                <div id="viewerContainer"/>
            </div>
        );
    }
}
