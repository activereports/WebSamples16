<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Default.aspx.vb" Inherits="GrapeCity.ActiveReports.Samples.Web._Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" type="text/css" href="CSS/default.css"/>
    <title>ActiveReports Standard Edition Web Sample</title>
</head>
<body>
    
    <div id="pagetop">
        <div id="pagetitlebanner">
            <h1>
                <a href="Default.aspx">ActiveReports Standard Edition Web Sample</a></h1>
        </div>
    </div>
    <div id="pagebody">
     <h2>
            ActiveReports for ASP.NET Standard Edition Options</h2>
        <!-- WebControl -->
        <a href="WebControl.aspx">WebControl for ASP.NET</a>
        <br/>
        For easy to use, robust browser based viewing and easy drag-and-drop development
        ActiveReports includes the server side ASP.NET WebControl. The web control supports
        the following <b>viewer types</b> for viewing reports in the browser:
 
                <br />
            <b>Html Viewer</b>
      
                &nbsp;Provides a scrollable view of a single page of the report at a time. Downloads
            only HTML and JavaScript to the client browser. Not preferable for printable output.<p>
            <br /><b>PDF Reader</b>
          
                Returns output as a PDF document viewable in Adobe Reader. Client Requirements:
            Adobe Reader.</p>
          <p>
            <br /><b>Raw Html</b>
        
                Shows all pages in the report document as a single HTML continuous page. Provides
                a static view of the entire report document, and usually decent printable output,
                although under some circumstances, pagination is not preserved. 
          </p>

        <!-- Raw Exporting -->
        <p>
            <a href="ParameterReport.aspx">Parameterized Report Example</a>
            <br/>
            This sample demonstrates how to generate a report by passing a parameter 
            to the report.
        </p>

    </div>
    <form id="form1" runat="server">
    </form>
</body>
</html>
