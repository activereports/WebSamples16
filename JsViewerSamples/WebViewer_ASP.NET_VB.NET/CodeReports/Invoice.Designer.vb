Namespace CodeReports
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Partial Public Class Invoice
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
		<System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Invoice))
			Me.txtProductID = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
			Me.txtProductname = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
			Me.txtQty = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
			Me.txtUnitPrice = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
			Me.txtDiscount = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
			Me.txtExtended = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
			Me.lblNWAddr1 = New GrapeCity.ActiveReports.SectionReportModel.Label()
			Me.lblNWAddr2 = New GrapeCity.ActiveReports.SectionReportModel.Label()
			Me.lblInvoice = New GrapeCity.ActiveReports.SectionReportModel.Label()
			Me.lblOrderNum = New GrapeCity.ActiveReports.SectionReportModel.Label()
			Me.txtOrderID = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
			Me.lblOrderDate = New GrapeCity.ActiveReports.SectionReportModel.Label()
			Me.txtOrderDate = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
			Me.imgLogo = New GrapeCity.ActiveReports.SectionReportModel.Picture()
			Me.lblThankyou = New GrapeCity.ActiveReports.SectionReportModel.Label()
			Me.lblBillTo = New GrapeCity.ActiveReports.SectionReportModel.Label()
			Me.lblShipTo = New GrapeCity.ActiveReports.SectionReportModel.Label()
			Me.lneBillTo = New GrapeCity.ActiveReports.SectionReportModel.Line()
			Me.LneShipTo = New GrapeCity.ActiveReports.SectionReportModel.Line()
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
			Me.lblSalesPerson = New GrapeCity.ActiveReports.SectionReportModel.Label()
			Me.lblProductId = New GrapeCity.ActiveReports.SectionReportModel.Label()
			Me.lblProductName = New GrapeCity.ActiveReports.SectionReportModel.Label()
			Me.lblQty = New GrapeCity.ActiveReports.SectionReportModel.Label()
			Me.lblUnitPrice = New GrapeCity.ActiveReports.SectionReportModel.Label()
			Me.lblDiscount = New GrapeCity.ActiveReports.SectionReportModel.Label()
			Me.lblTotal = New GrapeCity.ActiveReports.SectionReportModel.Label()
			Me.lblShipped = New GrapeCity.ActiveReports.SectionReportModel.Label()
			Me.txtShipDate = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
			Me.lblShippedVia = New GrapeCity.ActiveReports.SectionReportModel.Label()
			Me.txtShipper = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
			Me.lblSubTotal = New GrapeCity.ActiveReports.SectionReportModel.Label()
			Me.lblFreight = New GrapeCity.ActiveReports.SectionReportModel.Label()
			Me.lblInvoiceTotal = New GrapeCity.ActiveReports.SectionReportModel.Label()
			Me.txtSubTotal = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
			Me.txtFreight = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
			Me.txtTotal = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
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
			CType(Me.lblOrderNum, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.txtOrderID, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lblOrderDate, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.txtOrderDate, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.imgLogo, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lblThankyou, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lblBillTo, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lblShipTo, System.ComponentModel.ISupportInitialize).BeginInit()
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
			CType(Me.lblSalesPerson, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lblProductId, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lblProductName, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lblQty, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lblUnitPrice, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lblDiscount, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lblTotal, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lblShipped, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.txtShipDate, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lblShippedVia, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.txtShipper, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lblSubTotal, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lblFreight, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lblInvoiceTotal, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.txtSubTotal, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.txtFreight, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.txtTotal, System.ComponentModel.ISupportInitialize).BeginInit()
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
			'lblOrderNum
			'
			resources.ApplyResources(Me.lblOrderNum, "lblOrderNum")
			Me.lblOrderNum.Name = "lblOrderNum"
			'
			'txtOrderID
			'
			Me.txtOrderID.CanGrow = False
			Me.txtOrderID.DataField = "OrderID"
			resources.ApplyResources(Me.txtOrderID, "txtOrderID")
			Me.txtOrderID.Name = "txtOrderID"
			'
			'lblOrderDate
			'
			resources.ApplyResources(Me.lblOrderDate, "lblOrderDate")
			Me.lblOrderDate.Name = "lblOrderDate"
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
			Me.imgLogo.LineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
			Me.imgLogo.LineWeight = 1.0!
			Me.imgLogo.Name = "imgLogo"
			Me.imgLogo.SizeMode = GrapeCity.ActiveReports.SectionReportModel.SizeModes.Zoom
			'
			'lblThankyou
			'
			resources.ApplyResources(Me.lblThankyou, "lblThankyou")
			Me.lblThankyou.Name = "lblThankyou"
			'
			'lblBillTo
			'
			resources.ApplyResources(Me.lblBillTo, "lblBillTo")
			Me.lblBillTo.Name = "lblBillTo"
			'
			'lblShipTo
			'
			resources.ApplyResources(Me.lblShipTo, "lblShipTo")
			Me.lblShipTo.Name = "lblShipTo"
			'
			'lneBillTo
			'
			resources.ApplyResources(Me.lneBillTo, "lneBillTo")
			Me.lneBillTo.LineWeight = 2.0!
			Me.lneBillTo.Name = "lneBillTo"
			Me.lneBillTo.X1 = 0!
			Me.lneBillTo.X2 = 3.0!
			Me.lneBillTo.Y1 = 0.2!
			Me.lneBillTo.Y2 = 0.2!
			'
			'LneShipTo
			'
			resources.ApplyResources(Me.LneShipTo, "LneShipTo")
			Me.LneShipTo.LineWeight = 2.0!
			Me.LneShipTo.Name = "LneShipTo"
			Me.LneShipTo.X1 = 6.458!
			Me.LneShipTo.X2 = 3.458!
			Me.LneShipTo.Y1 = 0.2!
			Me.LneShipTo.Y2 = 0.2!
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
			'lblSalesPerson
			'
			resources.ApplyResources(Me.lblSalesPerson, "lblSalesPerson")
			Me.lblSalesPerson.Name = "lblSalesPerson"
			'
			'lblProductId
			'
			resources.ApplyResources(Me.lblProductId, "lblProductId")
			Me.lblProductId.Name = "lblProductId"
			'
			'lblProductName
			'
			resources.ApplyResources(Me.lblProductName, "lblProductName")
			Me.lblProductName.Name = "lblProductName"
			'
			'lblQty
			'
			resources.ApplyResources(Me.lblQty, "lblQty")
			Me.lblQty.Name = "lblQty"
			'
			'lblUnitPrice
			'
			resources.ApplyResources(Me.lblUnitPrice, "lblUnitPrice")
			Me.lblUnitPrice.Name = "lblUnitPrice"
			'
			'lblDiscount
			'
			resources.ApplyResources(Me.lblDiscount, "lblDiscount")
			Me.lblDiscount.Name = "lblDiscount"
			'
			'lblTotal
			'
			resources.ApplyResources(Me.lblTotal, "lblTotal")
			Me.lblTotal.Name = "lblTotal"
			'
			'lblShipped
			'
			resources.ApplyResources(Me.lblShipped, "lblShipped")
			Me.lblShipped.Name = "lblShipped"
			'
			'txtShipDate
			'
			Me.txtShipDate.CanGrow = False
			Me.txtShipDate.DataField = "ShippedDate"
			resources.ApplyResources(Me.txtShipDate, "txtShipDate")
			Me.txtShipDate.Name = "txtShipDate"
			'
			'lblShippedVia
			'
			resources.ApplyResources(Me.lblShippedVia, "lblShippedVia")
			Me.lblShippedVia.Name = "lblShippedVia"
			'
			'txtShipper
			'
			Me.txtShipper.CanGrow = False
			Me.txtShipper.DataField = "Shippers.CompanyName"
			resources.ApplyResources(Me.txtShipper, "txtShipper")
			Me.txtShipper.Name = "txtShipper"
			'
			'lblSubTotal
			'
			resources.ApplyResources(Me.lblSubTotal, "lblSubTotal")
			Me.lblSubTotal.Name = "lblSubTotal"
			'
			'lblFreight
			'
			resources.ApplyResources(Me.lblFreight, "lblFreight")
			Me.lblFreight.Name = "lblFreight"
			'
			'lblInvoiceTotal
			'
			resources.ApplyResources(Me.lblInvoiceTotal, "lblInvoiceTotal")
			Me.lblInvoiceTotal.Name = "lblInvoiceTotal"
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
			Me.PageHeader.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.lblNWAddr1, Me.lblNWAddr2, Me.lblInvoice, Me.lblOrderNum, Me.txtOrderID, Me.lblOrderDate, Me.txtOrderDate, Me.imgLogo, Me.Picture1})
			Me.PageHeader.Height = 1.18125!
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
			Me.ghOrderID.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.lblBillTo, Me.lblShipTo, Me.lneBillTo, Me.LneShipTo, Me.txtBillToCompany, Me.txtBillToAddress, Me.txtBillToCity, Me.txtBillToRegion, Me.txtBillToPostalCode, Me.txtBillToCountry, Me.txtShipToCompany, Me.txtShipToAddress, Me.txtShipToCity, Me.txtShipToRegion, Me.txtShipToPostalCode, Me.txtShipToCountry, Me.txtSalesPerson, Me.lblSalesPerson, Me.lblProductId, Me.lblProductName, Me.lblQty, Me.lblUnitPrice, Me.lblDiscount, Me.lblTotal, Me.lblShipped, Me.txtShipDate, Me.lblShippedVia, Me.txtShipper})
			Me.ghOrderID.DataField = "OrderID"
			Me.ghOrderID.Height = 1.579!
			Me.ghOrderID.KeepTogether = True
			Me.ghOrderID.Name = "ghOrderID"
			'
			'GFOrderID
			'
			Me.GFOrderID.CanGrow = False
			Me.GFOrderID.ColumnLayout = False
			Me.GFOrderID.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.lblSubTotal, Me.lblFreight, Me.lblInvoiceTotal, Me.txtSubTotal, Me.txtFreight, Me.txtTotal})
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
			'Invoice
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
			Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: ita" &
			"lic; ddo-char-set: 186", "Heading2", "Normal"))
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
			CType(Me.lblOrderNum, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.txtOrderID, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lblOrderDate, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.txtOrderDate, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.imgLogo, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lblThankyou, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lblBillTo, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lblShipTo, System.ComponentModel.ISupportInitialize).EndInit()
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
			CType(Me.lblSalesPerson, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lblProductId, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lblProductName, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lblQty, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lblUnitPrice, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lblDiscount, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lblTotal, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lblShipped, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.txtShipDate, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lblShippedVia, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.txtShipper, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lblSubTotal, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lblFreight, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lblInvoiceTotal, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.txtSubTotal, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.txtFreight, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.txtTotal, System.ComponentModel.ISupportInitialize).EndInit()
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
		Private WithEvents lblOrderNum As GrapeCity.ActiveReports.SectionReportModel.Label
		Private WithEvents txtOrderID As GrapeCity.ActiveReports.SectionReportModel.TextBox
		Private WithEvents lblOrderDate As GrapeCity.ActiveReports.SectionReportModel.Label
		Private WithEvents txtOrderDate As GrapeCity.ActiveReports.SectionReportModel.TextBox
		Private WithEvents imgLogo As GrapeCity.ActiveReports.SectionReportModel.Picture
		Private WithEvents PageFooter As GrapeCity.ActiveReports.SectionReportModel.PageFooter
		Private WithEvents lblThankyou As GrapeCity.ActiveReports.SectionReportModel.Label
		Private WithEvents ghOrderID As GrapeCity.ActiveReports.SectionReportModel.GroupHeader
		Private WithEvents lblBillTo As GrapeCity.ActiveReports.SectionReportModel.Label
		Private WithEvents lblShipTo As GrapeCity.ActiveReports.SectionReportModel.Label
		Private WithEvents lneBillTo As GrapeCity.ActiveReports.SectionReportModel.Line
		Private WithEvents LneShipTo As GrapeCity.ActiveReports.SectionReportModel.Line
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
		Private WithEvents lblSalesPerson As GrapeCity.ActiveReports.SectionReportModel.Label
		Private WithEvents lblProductId As GrapeCity.ActiveReports.SectionReportModel.Label
		Private WithEvents lblProductName As GrapeCity.ActiveReports.SectionReportModel.Label
		Private WithEvents lblQty As GrapeCity.ActiveReports.SectionReportModel.Label
		Private WithEvents lblUnitPrice As GrapeCity.ActiveReports.SectionReportModel.Label
		Private WithEvents lblDiscount As GrapeCity.ActiveReports.SectionReportModel.Label
		Private WithEvents lblTotal As GrapeCity.ActiveReports.SectionReportModel.Label
		Private WithEvents lblShipped As GrapeCity.ActiveReports.SectionReportModel.Label
		Private WithEvents txtShipDate As GrapeCity.ActiveReports.SectionReportModel.TextBox
		Private WithEvents lblShippedVia As GrapeCity.ActiveReports.SectionReportModel.Label
		Private WithEvents txtShipper As GrapeCity.ActiveReports.SectionReportModel.TextBox
		Private WithEvents GFOrderID As GrapeCity.ActiveReports.SectionReportModel.GroupFooter
		Private WithEvents lblSubTotal As GrapeCity.ActiveReports.SectionReportModel.Label
		Private WithEvents lblFreight As GrapeCity.ActiveReports.SectionReportModel.Label
		Private WithEvents lblInvoiceTotal As GrapeCity.ActiveReports.SectionReportModel.Label
		Private WithEvents txtSubTotal As GrapeCity.ActiveReports.SectionReportModel.TextBox
		Private WithEvents txtFreight As GrapeCity.ActiveReports.SectionReportModel.TextBox
		Private WithEvents txtTotal As GrapeCity.ActiveReports.SectionReportModel.TextBox
		Private WithEvents Picture1 As SectionReportModel.Picture
	End Class
End Namespace