<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ParameterReport.aspx.cs" Inherits="GrapeCity.ActiveReports.Samples.Web.ParameterReport" %>
<%@ Register TagPrefix="activereportsweb" Namespace="GrapeCity.ActiveReports.Web" assembly="GrapeCity.ActiveReports.Web" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	 <link rel="stylesheet" type="text/css" href="CSS/default.css"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div id="navigation">
            <asp:Panel ID="Panel1" runat="server" GroupingText="Date Picker" Height="236px" 
                Width="250px" Direction="LeftToRight" Style="float:left">
                &nbsp;<asp:Calendar id="Calendar1" runat="server" Width="167px" Height="61px"  
                    Font-Names="Verdana" Font-Size="Small" 
                    onselectionchanged="Calendar1_SelectionChanged">
	            </asp:Calendar>
            </asp:Panel>
            <asp:Panel ID="Panel2" runat="server" GroupingText="Select Viewer" 
                Height="115px" Width="197px" Style="margin-left:260px">
                <br />
                <br />
                <asp:DropDownList id="cboViewerType"
	            runat="server" Height="24px" Width="149px" AutoPostBack="True" 
                    onselectedindexchanged="cboViewerType_SelectedIndexChanged">
                </asp:DropDownList></asp:Panel>
        </div>
        <p style="clear:left"></p>

    </form>

    <ActiveReportsWeb:WebViewer ID="WebViewer1" runat="server" style="position: absolute;" Height="80%" Width="95%"/>
</body>
</html>
