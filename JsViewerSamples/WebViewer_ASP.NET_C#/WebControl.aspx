<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebControl.aspx.cs" Inherits="GrapeCity.ActiveReports.Samples.Web.WebControl" culture="auto"%>
<%@ Register TagPrefix="activereportsweb" Namespace="GrapeCity.ActiveReports.Web" assembly="GrapeCity.ActiveReports.Web" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>GrapeCity ActiveReports WebViewer Control</title>
    <link rel="stylesheet" type="text/css" href="CSS/default.css"/>
</head>
<body>
    <div id="pagetop" style="z-index: 101">
        <div id="pagetitlebanner">
            <h1>
                <a href="Default.aspx">ActiveReports Standard Edition Web Sample</a></h1>
            <h2>
                WebViewerControl Sample</h2>
        </div>
    </div>
     <div class="content" style="overflow: auto">
        The ActiveReports WebControl allows you to easily publish simple reports to the
        web for viewing in the browser. The client machine will not require ActiveReports,
        nor ASP.NET to be installed. Below is a simple example of the ActiveReports web
        control. To use the webcontrol you simply
        select an ActiveReport using the ReportName property of the webcontrol in the property
        list. Alternatively, you can set the ReportName property programmatically to a new instance
        of an ActiveReport class.
    </div>
    <form id="form1" runat="server">
        <asp:Label ID="lblViewerType" Style="z-index: 105; left: 24px; position: absolute;
            top: 175px" runat="server" Font-Bold="True">Select Viewer Type:</asp:Label>
        <asp:DropDownList ID="cboViewerType" Style="z-index: 103; left: 179px; position: absolute;
            top: 175px" runat="server" Width="149px"
           >
        </asp:DropDownList>
          <asp:Label ID="lblReportType" Style="z-index: 106; left: 350px; position: absolute;
            top: 175px" runat="server" Font-Bold="True">Select Report Type:</asp:Label>
        <asp:DropDownList ID="cboReportType" Style="z-index: 107; left: 505px; position: absolute;
            top: 175px" runat="server" Width="149px"
            >
            <asp:ListItem meta:resourcekey="liResourceSection"></asp:ListItem>
            <asp:ListItem meta:resourcekey="liResourcePage"></asp:ListItem>
            <asp:ListItem meta:resourcekey="liResourceRDL"></asp:ListItem>
        </asp:DropDownList>
        <asp:Button ID="commit" runat="server" Style="z-index: 108; left: 656px; position: absolute;
            top: 174px" OnClick="commit_Click" Width="65px" meta:resourceKey="commitResource"/>
    </form>

    <activereportsweb:WebViewer ID="arvWebMain" runat="server" Style="z-index: 102; left: 14px; position: absolute; top: 210px; height: calc(100% - 210px)" Width="95%" ReportName="RpxReports/Invoice.rpx"/>
</body>
</html>
