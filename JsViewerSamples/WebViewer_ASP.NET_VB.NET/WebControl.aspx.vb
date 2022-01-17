Public Class WebControl
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        ' Put user code to initialize the page here
        ' if this is not the postback, then fill the dropdown/combo with it's available viewer types.
        If Not IsPostBack Then
            cboViewerType.Items.Clear()
            cboViewerType.Items.Add("HtmlViewer")
            cboViewerType.Items.Add("PDF Reader")
            cboViewerType.Items.Add("RawHtml")
            ' Default is HTML.
            cboViewerType.SelectedIndex = 0

            ' Default is Section.
            cboReportType.SelectedIndex = 0
        End If
    End Sub

    '''  <summary>
    ''' commit_Click - runs when the user clicks the view button
    ''' and selects a different viewing mode.
    ''' </summary>
    Protected Sub commit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles commit.Click
        ' Set the Viewer Type from the dropdown list to the ActiveReports WebViewer
        Dim selectedViewerType As String = cboViewerType.Items(cboViewerType.SelectedIndex).Text

        ' Set the Report Type from the dropdown list to the ActiveReports WebViewer
        Dim selectedReportType As Integer = cboReportType.SelectedIndex

        Select Case selectedViewerType
            Case "PDF Reader"
                ' Acrobat Reader was chosen as the viewer type
                arvWebMain.ViewerType = ActiveReports.Web.ViewerType.AcrobatReader
                Exit Select
            Case "HtmlViewer"
                ' HTML Viewer was chosen as the viewer type
                arvWebMain.ViewerType = ActiveReports.Web.ViewerType.HtmlViewer
                Exit Select
            Case "RawHtml"
                ' Raw HTML was chosen as the viewer type
                arvWebMain.ViewerType = ActiveReports.Web.ViewerType.RawHtml
                Exit Select
        End Select

        Select Case selectedReportType
            Case 0
                ' Section Report was chosen as the report type
                arvWebMain.ReportName = "RpxReports/Invoice.rpx"
                Exit Select
            Case 1
                ' Page Report was chosen as the report type
                arvWebMain.ReportName = "PageReports/Invoice_Grouped.rdlx"
                Exit Select
            Case 2
                ' RDL Report was chosen as the report type
                arvWebMain.ReportName = "RdlReports/SalesReceipt.rdlx"
                Exit Select
        End Select
    End Sub
End Class