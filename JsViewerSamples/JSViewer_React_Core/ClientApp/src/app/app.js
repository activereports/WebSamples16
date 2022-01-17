import React, {Component} from "react";
import '../styles/app.css';
import Viewer from "./components/viewer";
import ReportList from "./components/reportList";

export default class App extends Component {
    constructor(props) {
        super(props);
        this.state = {
            reportsList: [],
            selectedReport: ""
        };
    }

    componentWillMount() {
        this.populateReports();
    }

    populateReports() {
        fetch('reports')
            .then(response => response.json())
            .then(result => {
                if(result.length > 0){
                    this.setState({
                        selectedReport: result[0],
                        reportsList: result
                    });
                }
            })
            .catch(e => {
                console.log(e);
            });
    };

    selectReport = (reportName) => {
        this.setState({
            selectedReport: reportName
        });
    };

    render() {
        return (
            <div className="main">
                <ReportList items={this.state.reportsList}
                            selectedReport={this.state.selectedReport}
                            selectReport={this.selectReport}
                />
                <Viewer reportName={this.state.selectedReport}/>
            </div>
        );
    }
}