Namespace CodeReports


	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
	Partial Public Class NwindLabels
		Inherits GrapeCity.ActiveReports.SectionReport

		'Form overrides dispose to clean up the component list.
		Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
			End If
			MyBase.Dispose(disposing)
		End Sub

		'NOTE: The following procedure is required by the ActiveReports Designer
		'It can be modified using the ActiveReports Designer.
		'Do not modify it using the code editor.
		<System.Diagnostics.DebuggerStepThrough()> _
		Private Sub InitializeComponent()
			Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NwindLabels))
			Me.lblAddr1 = New GrapeCity.ActiveReports.SectionReportModel.Label()
			Me.lblAddr2 = New GrapeCity.ActiveReports.SectionReportModel.Label()
			Me.linSep1 = New GrapeCity.ActiveReports.SectionReportModel.Line()
			Me.txtName = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
			Me.txtAddress = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
			Me.txtCity = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
			Me.txtRegion = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
			Me.txtPostalCode = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
			Me.txtCountry = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
			Me.Detail = New GrapeCity.ActiveReports.SectionReportModel.Detail()
			Me.PageHeader = New GrapeCity.ActiveReports.SectionReportModel.PageHeader()
			Me.PageFooter = New GrapeCity.ActiveReports.SectionReportModel.PageFooter()
			Me.Picture1 = New GrapeCity.ActiveReports.SectionReportModel.Picture()
			CType(Me.lblAddr1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lblAddr2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.txtName, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.txtAddress, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.txtCity, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.txtRegion, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.txtPostalCode, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.txtCountry, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.Picture1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			'
			'lblAddr1
			'
			resources.ApplyResources(Me.lblAddr1, "lblAddr1")
			Me.lblAddr1.Name = "lblAddr1"
			'
			'lblAddr2
			'
			resources.ApplyResources(Me.lblAddr2, "lblAddr2")
			Me.lblAddr2.Name = "lblAddr2"
			'
			'linSep1
			'
			resources.ApplyResources(Me.linSep1, "linSep1")
			Me.linSep1.LineWeight = 2.0!
			Me.linSep1.Name = "linSep1"
			Me.linSep1.X1 = 0.0625!
			Me.linSep1.X2 = 3.1875!
			Me.linSep1.Y1 = 0.625!
			Me.linSep1.Y2 = 0.625!
			'
			'txtName
			'
			Me.txtName.CanGrow = False
			Me.txtName.DataField = "CompanyName"
			resources.ApplyResources(Me.txtName, "txtName")
			Me.txtName.Name = "txtName"
			'
			'txtAddress
			'
			Me.txtAddress.DataField = "Address"
			resources.ApplyResources(Me.txtAddress, "txtAddress")
			Me.txtAddress.Name = "txtAddress"
			'
			'txtCity
			'
			Me.txtCity.CanGrow = False
			Me.txtCity.DataField = "City"
			resources.ApplyResources(Me.txtCity, "txtCity")
			Me.txtCity.Name = "txtCity"
			'
			'txtRegion
			'
			Me.txtRegion.CanGrow = False
			Me.txtRegion.DataField = "Region"
			resources.ApplyResources(Me.txtRegion, "txtRegion")
			Me.txtRegion.Name = "txtRegion"
			'
			'txtPostalCode
			'
			Me.txtPostalCode.CanGrow = False
			Me.txtPostalCode.DataField = "PostalCode"
			resources.ApplyResources(Me.txtPostalCode, "txtPostalCode")
			Me.txtPostalCode.Name = "txtPostalCode"
			'
			'txtCountry
			'
			Me.txtCountry.CanGrow = False
			Me.txtCountry.DataField = "Country"
			resources.ApplyResources(Me.txtCountry, "txtCountry")
			Me.txtCountry.Name = "txtCountry"
			'
			'Detail
			'
			Me.Detail.CanGrow = False
			Me.Detail.ColumnCount = 2
			Me.Detail.ColumnDirection = GrapeCity.ActiveReports.SectionReportModel.ColumnDirection.AcrossDown
			Me.Detail.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.lblAddr1, Me.lblAddr2, Me.linSep1, Me.txtName, Me.txtAddress, Me.txtCity, Me.txtRegion, Me.txtPostalCode, Me.txtCountry, Me.Picture1})
			Me.Detail.Height = 1.487!
			Me.Detail.KeepTogether = True
			Me.Detail.Name = "Detail"
			'
			'PageHeader
			'
			Me.PageHeader.CanGrow = False
			Me.PageHeader.Height = 0!
			Me.PageHeader.Name = "PageHeader"
			'
			'PageFooter
			'
			Me.PageFooter.CanGrow = False
			Me.PageFooter.Name = "PageFooter"
			'
			'Picture1
			'
			Me.Picture1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
			resources.ApplyResources(Me.Picture1, "Picture1")
			Me.Picture1.ImageData = CType(resources.GetObject("Picture1.ImageData"), System.IO.Stream)
			Me.Picture1.LineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
			Me.Picture1.LineWeight = 1.0!
			Me.Picture1.Name = "Picture1"
			Me.Picture1.SizeMode = GrapeCity.ActiveReports.SectionReportModel.SizeModes.Zoom
			'
			'NwindLabels
			'
			Me.MasterReport = False
			Me.PageSettings.PaperHeight = 11.0!
			Me.PageSettings.PaperWidth = 8.5!
			Me.Sections.Add(Me.PageHeader)
			Me.Sections.Add(Me.Detail)
			Me.Sections.Add(Me.PageFooter)
			Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" &
			"l; font-size: 10pt; color: Black; ddo-char-set: 186", "Normal"))
			Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold; ddo-char-set: 186", "Heading1", "Normal"))
			Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: ita" &
			"lic; ddo-char-set: 186", "Heading2", "Normal"))
			Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold; ddo-char-set: 186", "Heading3", "Normal"))
			CType(Me.lblAddr1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lblAddr2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.txtName, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.txtAddress, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.txtCity, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.txtRegion, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.txtPostalCode, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.txtCountry, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.Picture1, System.ComponentModel.ISupportInitialize).EndInit()
			AddHandler Me.FetchData, New FetchEventHandler(AddressOf Me.ActiveReport_FetchData)
			AddHandler Me.DataInitialize, New System.EventHandler(AddressOf Me.ActiveReport_DataInitialize)
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub
		Private WithEvents Detail As GrapeCity.ActiveReports.SectionReportModel.Detail
		Private WithEvents lblAddr1 As GrapeCity.ActiveReports.SectionReportModel.Label
		Private WithEvents lblAddr2 As GrapeCity.ActiveReports.SectionReportModel.Label
		Private WithEvents linSep1 As GrapeCity.ActiveReports.SectionReportModel.Line
		Private WithEvents txtName As GrapeCity.ActiveReports.SectionReportModel.TextBox
		Private WithEvents txtAddress As GrapeCity.ActiveReports.SectionReportModel.TextBox
		Private WithEvents txtCity As GrapeCity.ActiveReports.SectionReportModel.TextBox
		Private WithEvents txtRegion As GrapeCity.ActiveReports.SectionReportModel.TextBox
		Private WithEvents txtPostalCode As GrapeCity.ActiveReports.SectionReportModel.TextBox
		Private WithEvents txtCountry As GrapeCity.ActiveReports.SectionReportModel.TextBox
		Private WithEvents PageHeader As GrapeCity.ActiveReports.SectionReportModel.PageHeader
		Private WithEvents PageFooter As GrapeCity.ActiveReports.SectionReportModel.PageFooter
		Private WithEvents Picture1 As SectionReportModel.Picture
	End Class
End Namespace