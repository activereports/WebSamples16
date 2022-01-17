Imports System.Globalization

Public Class ParameterReport
    Inherits System.Web.UI.Page

    Dim _rpt As New SectionReport

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        ' Load the report layout
        Dim xtr As New System.Xml.XmlTextReader(Server.MapPath("~") + "\RpxReports\Params.rpx")
        _rpt.LoadLayout(xtr)
        xtr.Close()
        If Not IsPostBack Then

            ' Sets the combo box.
            cboViewerType.Items.Clear()
            cboViewerType.Items.Add("HTML")
            cboViewerType.Items.Add("AcrobatReader")
            cboViewerType.Items.Add("RawHtml")
            ' The default is set to HTML viewer.
            cboViewerType.SelectedIndex = 0
            Dim initDate As New DateTime(1994, 8, 2)
            Calendar1.VisibleDate = initDate

        End If
        _rpt.Restart()
        WebViewer1.Report = _rpt
        Session("Report") = _rpt
    End Sub

    Protected Sub cboViewerType_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
        ' Select Viewer Type
        Dim selection As String = cboViewerType.Items(cboViewerType.SelectedIndex).Text
        Select Case selection
            ' Sets Viewer type to Acrobat Reader
            Case "AcrobatReader"
                Session("ViewerType") = ActiveReports.Web.ViewerType.AcrobatReader
                Exit Select
                ' Sets Viewer type to HTML
            Case "HTML"
                Session("ViewerType") = ActiveReports.Web.ViewerType.HtmlViewer
                Exit Select
                ' Sets Viewer type to RAW HTML
            Case "RawHtml"
                Session("ViewerType") = ActiveReports.Web.ViewerType.RawHtml
                Exit Select
        End Select
        ' Save Report and Viewer Type to session.
        WebViewer1.Report = Session("Report")
        WebViewer1.ViewerType = DirectCast(Session("ViewerType"), ActiveReports.Web.ViewerType)
    End Sub

    Protected Sub Calendar1_SelectionChanged(ByVal sender As Object, ByVal e As EventArgs)
        ' Set Viewer Type
        If Session("ViewerType") IsNot Nothing Then
            WebViewer1.ViewerType = DirectCast(Session("ViewerType"), ActiveReports.Web.ViewerType)
        Else
            WebViewer1.ViewerType = ActiveReports.Web.ViewerType.HtmlViewer
        End If

        ' Filter report data based on selected date
        _rpt.Parameters.Item(0).DefaultValue = Calendar1.SelectedDate.ToString("MM/dd/yyyy", CultureInfo.InvariantCulture)
    End Sub
End Class