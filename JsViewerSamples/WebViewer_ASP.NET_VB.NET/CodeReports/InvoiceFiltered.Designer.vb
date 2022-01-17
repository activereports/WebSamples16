Namespace CodeReports


	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
	Partial Public Class InvoiceFiltered
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
			Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InvoiceFiltered))
			Me.StartingDate = New SectionReportModel.Parameter()
			Me.EndingDate = New SectionReportModel.Parameter()
			Me.Parameters.Add(Me.StartingDate)
			Me.Parameters.Add(Me.EndingDate)
			Me.txtProductID = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
			Me.txtProductname = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
			Me.txtQty = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
			Me.txtUnitPrice = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
			Me.txtDiscount = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
			Me.txtExtended = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
			Me.lblNWAddr1 = New GrapeCity.ActiveReports.SectionReportModel.Label()
			Me.lblNWAddr2 = New GrapeCity.ActiveReports.SectionReportModel.Label()
			Me.lblInvoice = New GrapeCity.ActiveReports.SectionReportModel.Label()
			Me.Label1 = New GrapeCity.ActiveReports.SectionReportModel.Label()
			Me.txtOrderID = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
			Me.Label2 = New GrapeCity.ActiveReports.SectionReportModel.Label()
			Me.txtOrderDate = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
			Me.imgLogo = New GrapeCity.ActiveReports.SectionReportModel.Picture()
			Me.lblThankyou = New GrapeCity.ActiveReports.SectionReportModel.Label()
			Me.Label3 = New GrapeCity.ActiveReports.SectionReportModel.Label()
			Me.Label = New GrapeCity.ActiveReports.SectionReportModel.Label()
			Me.Line1 = New GrapeCity.ActiveReports.SectionReportModel.Line()
			Me.Line2 = New GrapeCity.ActiveReports.SectionReportModel.Line()
			Me.txtBillToCompany = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
			Me.txtBillToAddress = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
			Me.txtBillToCity = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
			Me.txtBillToRegion = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
			Me.txtBillToPostalCode = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
			Me.txtBillToCountry = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
			Me.txtShipToCompany = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
			Me.txtShipToAddress = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
			Me.txtShipToCity = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
			Me.txtShipToRegion = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
			Me.txtShipToPostalCode = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
			Me.txtShipToCountry = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
			Me.txtSalesPerson = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
			Me.Label5 = New GrapeCity.ActiveReports.SectionReportModel.Label()
			Me.Label6 = New GrapeCity.ActiveReports.SectionReportModel.Label()
			Me.Label7 = New GrapeCity.ActiveReports.SectionReportModel.Label()
			Me.Label8 = New GrapeCity.ActiveReports.SectionReportModel.Label()
			Me.Label4 = New GrapeCity.ActiveReports.SectionReportModel.Label()
			Me.Label10 = New GrapeCity.ActiveReports.SectionReportModel.Label()
			Me.Label11 = New GrapeCity.ActiveReports.SectionReportModel.Label()
			Me.Label12 = New GrapeCity.ActiveReports.SectionReportModel.Label()
			Me.txtShipDate = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
			Me.Label13 = New GrapeCity.ActiveReports.SectionReportModel.Label()
			Me.txtShipper = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
			Me.Label9 = New GrapeCity.ActiveReports.SectionReportModel.Label()
			Me.Label14 = New GrapeCity.ActiveReports.SectionReportModel.Label()
			Me.Label15 = New GrapeCity.ActiveReports.SectionReportModel.Label()
			Me.txtSubTotal = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
			Me.txtFreight = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
			Me.txtTotal = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
			Me.Label16 = New GrapeCity.ActiveReports.SectionReportModel.Label()
			Me.Label17 = New GrapeCity.ActiveReports.SectionReportModel.Label()
			Me.Label18 = New GrapeCity.ActiveReports.SectionReportModel.Label()
			Me.Detail = New GrapeCity.ActiveReports.SectionReportModel.Detail()
			Me.PageHeader = New GrapeCity.ActiveReports.SectionReportModel.PageHeader()
			Me.PageFooter = New GrapeCity.ActiveReports.SectionReportModel.PageFooter()
			Me.ghOrderID = New GrapeCity.ActiveReports.SectionReportModel.GroupHeader()
			Me.GFOrderID = New GrapeCity.ActiveReports.SectionReportModel.GroupFooter()
			Me.Picture1 = New GrapeCity.ActiveReports.SectionReportModel.Picture()
			CType(Me.txtProductID, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.txtProductname, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.txtQty, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.txtUnitPrice, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.txtDiscount, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.txtExtended, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lblNWAddr1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lblNWAddr2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lblInvoice, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.txtOrderID, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.txtOrderDate, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.imgLogo, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lblThankyou, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.Label, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.txtBillToCompany, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.txtBillToAddress, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.txtBillToCity, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.txtBillToRegion, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.txtBillToPostalCode, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.txtBillToCountry, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.txtShipToCompany, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.txtShipToAddress, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.txtShipToCity, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.txtShipToRegion, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.txtShipToPostalCode, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.txtShipToCountry, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.txtSalesPerson, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.Label5, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.Label6, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.Label7, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.Label8, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.Label10, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.Label11, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.Label12, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.txtShipDate, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.Label13, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.txtShipper, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.Label9, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.Label14, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.Label15, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.txtSubTotal, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.txtFreight, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.txtTotal, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.Label16, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.Label17, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.Label18, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.Picture1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			'
			'txtProductID
			'
			Me.txtProductID.CanGrow = False
			Me.txtProductID.DataField = "ProductID"
			resources.ApplyResources(Me.txtProductID, "txtProductID")
			Me.txtProductID.Name = "txtProductID"
			'
			'txtProductname
			'
			Me.txtProductname.CanGrow = False
			Me.txtProductname.DataField = "ProductName"
			resources.ApplyResources(Me.txtProductname, "txtProductname")
			Me.txtProductname.Name = "txtProductname"
			'
			'txtQty
			'
			Me.txtQty.CanGrow = False
			Me.txtQty.DataField = "Quantity"
			resources.ApplyResources(Me.txtQty, "txtQty")
			Me.txtQty.Name = "txtQty"
			'
			'txtUnitPrice
			'
			Me.txtUnitPrice.CanGrow = False
			Me.txtUnitPrice.DataField = "UnitPrice"
			resources.ApplyResources(Me.txtUnitPrice, "txtUnitPrice")
			Me.txtUnitPrice.Name = "txtUnitPrice"
			'
			'txtDiscount
			'
			Me.txtDiscount.CanGrow = False
			Me.txtDiscount.DataField = "Discount"
			resources.ApplyResources(Me.txtDiscount, "txtDiscount")
			Me.txtDiscount.Name = "txtDiscount"
			'
			'txtExtended
			'
			Me.txtExtended.CanGrow = False
			Me.txtExtended.DataField = "ExtendedPrice"
			resources.ApplyResources(Me.txtExtended, "txtExtended")
			Me.txtExtended.Name = "txtExtended"
			'
			'lblNWAddr1
			'
			resources.ApplyResources(Me.lblNWAddr1, "lblNWAddr1")
			Me.lblNWAddr1.Name = "lblNWAddr1"
			'
			'lblNWAddr2
			'
			resources.ApplyResources(Me.lblNWAddr2, "lblNWAddr2")
			Me.lblNWAddr2.Name = "lblNWAddr2"
			'
			'lblInvoice
			'
			resources.ApplyResources(Me.lblInvoice, "lblInvoice")
			Me.lblInvoice.Name = "lblInvoice"
			'
			'Label1
			'
			resources.ApplyResources(Me.Label1, "Label1")
			Me.Label1.Name = "Label1"
			'
			'txtOrderID
			'
			Me.txtOrderID.CanGrow = False
			Me.txtOrderID.DataField = "OrderID"
			resources.ApplyResources(Me.txtOrderID, "txtOrderID")
			Me.txtOrderID.Name = "txtOrderID"
			'
			'Label2
			'
			resources.ApplyResources(Me.Label2, "Label2")
			Me.Label2.Name = "Label2"
			'
			'txtOrderDate
			'
			Me.txtOrderDate.CanGrow = False
			Me.txtOrderDate.DataField = "OrderDate"
			resources.ApplyResources(Me.txtOrderDate, "txtOrderDate")
			Me.txtOrderDate.MultiLine = False
			Me.txtOrderDate.Name = "txtOrderDate"
			'
			'imgLogo
			'
			Me.imgLogo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
			resources.ApplyResources(Me.imgLogo, "imgLogo")
			Me.imgLogo.ImageData = CType(resources.GetObject("imgLogo.ImageData"), System.IO.Stream)
			Me.imgLogo.LineWeight = 1.0!
			Me.imgLogo.Name = "imgLogo"
			Me.imgLogo.SizeMode = GrapeCity.ActiveReports.SectionReportModel.SizeModes.Zoom
			'
			'lblThankyou
			'
			resources.ApplyResources(Me.lblThankyou, "lblThankyou")
			Me.lblThankyou.Name = "lblThankyou"
			'
			'Label3
			'
			resources.ApplyResources(Me.Label3, "Label3")
			Me.Label3.Name = "Label3"
			'
			'Label
			'
			resources.ApplyResources(Me.Label, "Label")
			Me.Label.Name = "Label"
			'
			'Line1
			'
			resources.ApplyResources(Me.Line1, "Line1")
			Me.Line1.LineWeight = 2.0!
			Me.Line1.Name = "Line1"
			Me.Line1.X1 = 0!
			Me.Line1.X2 = 3.0!
			Me.Line1.Y1 = 0.2!
			Me.Line1.Y2 = 0.2!
			'
			'Line2
			'
			resources.ApplyResources(Me.Line2, "Line2")
			Me.Line2.LineWeight = 2.0!
			Me.Line2.Name = "Line2"
			Me.Line2.X1 = 6.46875!
			Me.Line2.X2 = 3.46875!
			Me.Line2.Y1 = 0.1875!
			Me.Line2.Y2 = 0.1875!
			'
			'txtBillToCompany
			'
			Me.txtBillToCompany.CanGrow = False
			Me.txtBillToCompany.DataField = "Customers.CompanyName"
			resources.ApplyResources(Me.txtBillToCompany, "txtBillToCompany")
			Me.txtBillToCompany.Name = "txtBillToCompany"
			'
			'txtBillToAddress
			'
			Me.txtBillToAddress.DataField = "Address"
			resources.ApplyResources(Me.txtBillToAddress, "txtBillToAddress")
			Me.txtBillToAddress.Name = "txtBillToAddress"
			'
			'txtBillToCity
			'
			Me.txtBillToCity.CanGrow = False
			Me.txtBillToCity.DataField = "City"
			resources.ApplyResources(Me.txtBillToCity, "txtBillToCity")
			Me.txtBillToCity.Name = "txtBillToCity"
			'
			'txtBillToRegion
			'
			Me.txtBillToRegion.CanGrow = False
			Me.txtBillToRegion.DataField = "Region"
			resources.ApplyResources(Me.txtBillToRegion, "txtBillToRegion")
			Me.txtBillToRegion.Name = "txtBillToRegion"
			'
			'txtBillToPostalCode
			'
			Me.txtBillToPostalCode.CanGrow = False
			Me.txtBillToPostalCode.DataField = "PostalCode"
			resources.ApplyResources(Me.txtBillToPostalCode, "txtBillToPostalCode")
			Me.txtBillToPostalCode.Name = "txtBillToPostalCode"
			'
			'txtBillToCountry
			'
			Me.txtBillToCountry.CanGrow = False
			Me.txtBillToCountry.DataField = "Country"
			resources.ApplyResources(Me.txtBillToCountry, "txtBillToCountry")
			Me.txtBillToCountry.Name = "txtBillToCountry"
			'
			'txtShipToCompany
			'
			Me.txtShipToCompany.CanGrow = False
			Me.txtShipToCompany.DataField = "ShipName"
			resources.ApplyResources(Me.txtShipToCompany, "txtShipToCompany")
			Me.txtShipToCompany.Name = "txtShipToCompany"
			'
			'txtShipToAddress
			'
			Me.txtShipToAddress.DataField = "ShipAddress"
			resources.ApplyResources(Me.txtShipToAddress, "txtShipToAddress")
			Me.txtShipToAddress.Name = "txtShipToAddress"
			'
			'txtShipToCity
			'
			Me.txtShipToCity.CanGrow = False
			Me.txtShipToCity.DataField = "ShipCity"
			resources.ApplyResources(Me.txtShipToCity, "txtShipToCity")
			Me.txtShipToCity.Name = "txtShipToCity"
			'
			'txtShipToRegion
			'
			Me.txtShipToRegion.CanGrow = False
			Me.txtShipToRegion.DataField = "ShipRegion"
			resources.ApplyResources(Me.txtShipToRegion, "txtShipToRegion")
			Me.txtShipToRegion.Name = "txtShipToRegion"
			'
			'txtShipToPostalCode
			'
			Me.txtShipToPostalCode.CanGrow = False
			Me.txtShipToPostalCode.DataField = "ShipPostalCode"
			resources.ApplyResources(Me.txtShipToPostalCode, "txtShipToPostalCode")
			Me.txtShipToPostalCode.Name = "txtShipToPostalCode"
			'
			'txtShipToCountry
			'
			Me.txtShipToCountry.CanGrow = False
			Me.txtShipToCountry.DataField = "ShipCountry"
			resources.ApplyResources(Me.txtShipToCountry, "txtShipToCountry")
			Me.txtShipToCountry.Name = "txtShipToCountry"
			'
			'txtSalesPerson
			'
			Me.txtSalesPerson.CanGrow = False
			Me.txtSalesPerson.DataField = "Salesperson"
			resources.ApplyResources(Me.txtSalesPerson, "txtSalesPerson")
			Me.txtSalesPerson.Name = "txtSalesPerson"
			'
			'Label5
			'
			resources.ApplyResources(Me.Label5, "Label5")
			Me.Label5.Name = "Label5"
			'
			'Label6
			'
			resources.ApplyResources(Me.Label6, "Label6")
			Me.Label6.Name = "Label6"
			'
			'Label7
			'
			resources.ApplyResources(Me.Label7, "Label7")
			Me.Label7.Name = "Label7"
			'
			'Label8
			'
			resources.ApplyResources(Me.Label8, "Label8")
			Me.Label8.Name = "Label8"
			'
			'Label4
			'
			resources.ApplyResources(Me.Label4, "Label4")
			Me.Label4.Name = "Label4"
			'
			'Label10
			'
			resources.ApplyResources(Me.Label10, "Label10")
			Me.Label10.Name = "Label10"
			'
			'Label11
			'
			resources.ApplyResources(Me.Label11, "Label11")
			Me.Label11.Name = "Label11"
			'
			'Label12
			'
			resources.ApplyResources(Me.Label12, "Label12")
			Me.Label12.Name = "Label12"
			'
			'txtShipDate
			'
			Me.txtShipDate.CanGrow = False
			Me.txtShipDate.DataField = "ShippedDate"
			resources.ApplyResources(Me.txtShipDate, "txtShipDate")
			Me.txtShipDate.Name = "txtShipDate"
			'
			'Label13
			'
			resources.ApplyResources(Me.Label13, "Label13")
			Me.Label13.Name = "Label13"
			'
			'txtShipper
			'
			Me.txtShipper.CanGrow = False
			Me.txtShipper.DataField = "Shippers.CompanyName"
			resources.ApplyResources(Me.txtShipper, "txtShipper")
			Me.txtShipper.Name = "txtShipper"
			'
			'Label9
			'
			resources.ApplyResources(Me.Label9, "Label9")
			Me.Label9.Name = "Label9"
			'
			'Label14
			'
			resources.ApplyResources(Me.Label14, "Label14")
			Me.Label14.Name = "Label14"
			'
			'Label15
			'
			resources.ApplyResources(Me.Label15, "Label15")
			Me.Label15.Name = "Label15"
			'
			'txtSubTotal
			'
			Me.txtSubTotal.CanGrow = False
			Me.txtSubTotal.DataField = "ExtendedPrice"
			resources.ApplyResources(Me.txtSubTotal, "txtSubTotal")
			Me.txtSubTotal.Name = "txtSubTotal"
			Me.txtSubTotal.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal
			'
			'txtFreight
			'
			Me.txtFreight.CanGrow = False
			Me.txtFreight.DataField = "Freight"
			resources.ApplyResources(Me.txtFreight, "txtFreight")
			Me.txtFreight.Name = "txtFreight"
			Me.txtFreight.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal
			'
			'txtTotal
			'
			Me.txtTotal.CanGrow = False
			resources.ApplyResources(Me.txtTotal, "txtTotal")
			Me.txtTotal.Name = "txtTotal"
			'
			'Label16
			'
			resources.ApplyResources(Me.Label16, "Label16")
			Me.Label16.Name = "Label16"
			'
			'Label17
			'
			resources.ApplyResources(Me.Label17, "Label17")
			Me.Label17.Name = "Label17"
			'
			'Label18
			'
			resources.ApplyResources(Me.Label18, "Label18")
			Me.Label18.Name = "Label18"
			'
			'Detail
			'
			Me.Detail.CanGrow = False
			Me.Detail.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.txtProductID, Me.txtProductname, Me.txtQty, Me.txtUnitPrice, Me.txtDiscount, Me.txtExtended})
			Me.Detail.Height = 0.2!
			Me.Detail.KeepTogether = True
			Me.Detail.Name = "Detail"
			'
			'PageHeader
			'
			Me.PageHeader.CanGrow = False
			Me.PageHeader.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.lblNWAddr1, Me.lblNWAddr2, Me.lblInvoice, Me.Label1, Me.txtOrderID, Me.Label2, Me.txtOrderDate, Me.imgLogo, Me.Picture1})
			Me.PageHeader.Height = 1.15!
			Me.PageHeader.Name = "PageHeader"
			'
			'PageFooter
			'
			Me.PageFooter.CanGrow = False
			Me.PageFooter.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.lblThankyou})
			Me.PageFooter.Name = "PageFooter"
			'
			'ghOrderID
			'
			Me.ghOrderID.ColumnLayout = False
			Me.ghOrderID.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.Label3, Me.Label, Me.Line1, Me.Line2, Me.txtBillToCompany, Me.txtBillToAddress, Me.txtBillToCity, Me.txtBillToRegion, Me.txtBillToPostalCode, Me.txtBillToCountry, Me.txtShipToCompany, Me.txtShipToAddress, Me.txtShipToCity, Me.txtShipToRegion, Me.txtShipToPostalCode, Me.txtShipToCountry, Me.txtSalesPerson, Me.Label5, Me.Label6, Me.Label7, Me.Label8, Me.Label4, Me.Label10, Me.Label11, Me.Label12, Me.txtShipDate, Me.Label13, Me.txtShipper, Me.Label16, Me.Label17, Me.Label18})
			Me.ghOrderID.DataField = "OrderID"
			Me.ghOrderID.Height = 1.581944!
			Me.ghOrderID.KeepTogether = True
			Me.ghOrderID.Name = "ghOrderID"
			'
			'GFOrderID
			'
			Me.GFOrderID.CanGrow = False
			Me.GFOrderID.ColumnLayout = False
			Me.GFOrderID.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.Label9, Me.Label14, Me.Label15, Me.txtSubTotal, Me.txtFreight, Me.txtTotal})
			Me.GFOrderID.Height = 0.6!
			Me.GFOrderID.KeepTogether = True
			Me.GFOrderID.Name = "GFOrderID"
			Me.GFOrderID.NewPage = GrapeCity.ActiveReports.SectionReportModel.NewPage.After
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
			'Starting date
			'
			Me.StartingDate.DefaultValue = "1994-8-1"
			Me.StartingDate.Key = "StartingDate"
			Me.StartingDate.Prompt = "Starting Date:"
			Me.StartingDate.PromptUser = True
			Me.StartingDate.QueryCreated = False
			Me.StartingDate.Tag = Nothing
			Me.StartingDate.Type = GrapeCity.ActiveReports.SectionReportModel.Parameter.DataType.Date
			'
			'Ending date
			'
			Me.EndingDate.DefaultValue = "1994-9-1"
			Me.EndingDate.Key = "EndingDate"
			Me.EndingDate.Prompt = "Ending Date:"
			Me.EndingDate.PromptUser = True
			Me.EndingDate.QueryCreated = False
			Me.EndingDate.Tag = Nothing
			Me.EndingDate.Type = GrapeCity.ActiveReports.SectionReportModel.Parameter.DataType.Date
			'
			'InvoiceFiltered
			'
			Me.MasterReport = False
			Me.MaxPages = CType(100, Long)
			Me.PageSettings.PaperHeight = 11.0!
			Me.PageSettings.PaperWidth = 8.5!
			Me.Script = resources.GetString("$this.Script")
			Me.Sections.Add(Me.PageHeader)
			Me.Sections.Add(Me.ghOrderID)
			Me.Sections.Add(Me.Detail)
			Me.Sections.Add(Me.GFOrderID)
			Me.Sections.Add(Me.PageFooter)
			Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" &
			"l; font-size: 10pt; color: Black; ddo-char-set: 186", "Normal"))
			Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold; ddo-char-set: 186", "Heading1", "Normal"))
			Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 14pt; font-weight: bold; font-style: italic; ddo-char-set: 186", "Heading2", "Normal"))
			Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold; ddo-char-set: 186", "Heading3", "Normal"))
			CType(Me.txtProductID, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.txtProductname, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.txtQty, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.txtUnitPrice, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.txtDiscount, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.txtExtended, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lblNWAddr1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lblNWAddr2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lblInvoice, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.txtOrderID, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.txtOrderDate, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.imgLogo, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lblThankyou, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.Label, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.txtBillToCompany, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.txtBillToAddress, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.txtBillToCity, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.txtBillToRegion, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.txtBillToPostalCode, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.txtBillToCountry, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.txtShipToCompany, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.txtShipToAddress, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.txtShipToCity, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.txtShipToRegion, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.txtShipToPostalCode, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.txtShipToCountry, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.txtSalesPerson, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.Label5, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.Label6, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.Label7, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.Label8, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.Label10, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.Label11, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.Label12, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.txtShipDate, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.Label13, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.txtShipper, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.Label9, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.Label14, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.Label15, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.txtSubTotal, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.txtFreight, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.txtTotal, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.Label16, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.Label17, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.Label18, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.Picture1, System.ComponentModel.ISupportInitialize).EndInit()
			AddHandler Me.FetchData, New FetchEventHandler(AddressOf Me.ActiveReport_FetchData)
			AddHandler Me.DataInitialize, New System.EventHandler(AddressOf Me.ActiveReport_DataInitialize)
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub
		Private WithEvents Detail As GrapeCity.ActiveReports.SectionReportModel.Detail
		Private WithEvents txtProductID As GrapeCity.ActiveReports.SectionReportModel.TextBox
		Private WithEvents txtProductname As GrapeCity.ActiveReports.SectionReportModel.TextBox
		Private WithEvents txtQty As GrapeCity.ActiveReports.SectionReportModel.TextBox
		Private WithEvents txtUnitPrice As GrapeCity.ActiveReports.SectionReportModel.TextBox
		Private WithEvents txtDiscount As GrapeCity.ActiveReports.SectionReportModel.TextBox
		Private WithEvents txtExtended As GrapeCity.ActiveReports.SectionReportModel.TextBox
		Private WithEvents PageHeader As GrapeCity.ActiveReports.SectionReportModel.PageHeader
		Private WithEvents lblNWAddr1 As GrapeCity.ActiveReports.SectionReportModel.Label
		Private WithEvents lblNWAddr2 As GrapeCity.ActiveReports.SectionReportModel.Label
		Private WithEvents lblInvoice As GrapeCity.ActiveReports.SectionReportModel.Label
		Private WithEvents Label1 As GrapeCity.ActiveReports.SectionReportModel.Label
		Private WithEvents txtOrderID As GrapeCity.ActiveReports.SectionReportModel.TextBox
		Private WithEvents Label2 As GrapeCity.ActiveReports.SectionReportModel.Label
		Private WithEvents txtOrderDate As GrapeCity.ActiveReports.SectionReportModel.TextBox
		Private WithEvents imgLogo As GrapeCity.ActiveReports.SectionReportModel.Picture
		Private WithEvents PageFooter As GrapeCity.ActiveReports.SectionReportModel.PageFooter
		Private WithEvents lblThankyou As GrapeCity.ActiveReports.SectionReportModel.Label
		Private WithEvents ghOrderID As GrapeCity.ActiveReports.SectionReportModel.GroupHeader
		Private WithEvents Label3 As GrapeCity.ActiveReports.SectionReportModel.Label
		Private WithEvents Label As GrapeCity.ActiveReports.SectionReportModel.Label
		Private WithEvents Line1 As GrapeCity.ActiveReports.SectionReportModel.Line
		Private WithEvents Line2 As GrapeCity.ActiveReports.SectionReportModel.Line
		Private WithEvents txtBillToCompany As GrapeCity.ActiveReports.SectionReportModel.TextBox
		Private WithEvents txtBillToAddress As GrapeCity.ActiveReports.SectionReportModel.TextBox
		Private WithEvents txtBillToCity As GrapeCity.ActiveReports.SectionReportModel.TextBox
		Private WithEvents txtBillToRegion As GrapeCity.ActiveReports.SectionReportModel.TextBox
		Private WithEvents txtBillToPostalCode As GrapeCity.ActiveReports.SectionReportModel.TextBox
		Private WithEvents txtBillToCountry As GrapeCity.ActiveReports.SectionReportModel.TextBox
		Private WithEvents txtShipToCompany As GrapeCity.ActiveReports.SectionReportModel.TextBox
		Private WithEvents txtShipToAddress As GrapeCity.ActiveReports.SectionReportModel.TextBox
		Private WithEvents txtShipToCity As GrapeCity.ActiveReports.SectionReportModel.TextBox
		Private WithEvents txtShipToRegion As GrapeCity.ActiveReports.SectionReportModel.TextBox
		Private WithEvents txtShipToPostalCode As GrapeCity.ActiveReports.SectionReportModel.TextBox
		Private WithEvents txtShipToCountry As GrapeCity.ActiveReports.SectionReportModel.TextBox
		Private WithEvents txtSalesPerson As GrapeCity.ActiveReports.SectionReportModel.TextBox
		Private WithEvents Label5 As GrapeCity.ActiveReports.SectionReportModel.Label
		Private WithEvents Label6 As GrapeCity.ActiveReports.SectionReportModel.Label
		Private WithEvents Label7 As GrapeCity.ActiveReports.SectionReportModel.Label
		Private WithEvents Label8 As GrapeCity.ActiveReports.SectionReportModel.Label
		Private WithEvents Label4 As GrapeCity.ActiveReports.SectionReportModel.Label
		Private WithEvents Label10 As GrapeCity.ActiveReports.SectionReportModel.Label
		Private WithEvents Label11 As GrapeCity.ActiveReports.SectionReportModel.Label
		Private WithEvents Label12 As GrapeCity.ActiveReports.SectionReportModel.Label
		Private WithEvents txtShipDate As GrapeCity.ActiveReports.SectionReportModel.TextBox
		Private WithEvents Label13 As GrapeCity.ActiveReports.SectionReportModel.Label
		Private WithEvents txtShipper As GrapeCity.ActiveReports.SectionReportModel.TextBox
		Private WithEvents GFOrderID As GrapeCity.ActiveReports.SectionReportModel.GroupFooter
		Private WithEvents Label9 As GrapeCity.ActiveReports.SectionReportModel.Label
		Private WithEvents Label14 As GrapeCity.ActiveReports.SectionReportModel.Label
		Private WithEvents Label15 As GrapeCity.ActiveReports.SectionReportModel.Label
		Private WithEvents txtSubTotal As GrapeCity.ActiveReports.SectionReportModel.TextBox
		Private WithEvents txtFreight As GrapeCity.ActiveReports.SectionReportModel.TextBox
		Private WithEvents txtTotal As GrapeCity.ActiveReports.SectionReportModel.TextBox
		Private WithEvents Label16 As GrapeCity.ActiveReports.SectionReportModel.Label
		Private WithEvents Label17 As GrapeCity.ActiveReports.SectionReportModel.Label
		Private WithEvents Label18 As GrapeCity.ActiveReports.SectionReportModel.Label
		Private WithEvents Picture1 As SectionReportModel.Picture
		Public WithEvents StartingDate As GrapeCity.ActiveReports.SectionReportModel.Parameter
		Public WithEvents EndingDate As GrapeCity.ActiveReports.SectionReportModel.Parameter
	End Class
End Namespace