import React, {Component} from "react";

export default class ReportList extends Component {
    render() {
        return (
            <div className="main-nav navbar">
                <div id='list-heading'> Select report</div>
                <ul id="reportsList" className="nav navbar-nav">
                    {this.props.items.map(name => (
                        <li className={"reportList_item" + (name === this.props.selectedReport ? " active" : "")}
                            key={name} onClick={() => {
                            this.props.selectReport(name)
                        }}>
                            <span>{name}</span>
                        </li>
                    ))}
                </ul>
            </div>
        );
    }
}