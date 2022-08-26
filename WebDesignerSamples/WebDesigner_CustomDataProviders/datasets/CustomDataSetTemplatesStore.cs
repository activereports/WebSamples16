using GrapeCity.ActiveReports.Aspnetcore.Designer;
using GrapeCity.ActiveReports.PageReportModel;
using System.Collections.Generic;

namespace WebDesignerCustomDataProviders.DataSets
{
	public static class CustomDataSetTemplatesStore
	{
		public static IDictionary<string, DataSetTemplate> Items { get; }

		static CustomDataSetTemplatesStore()
		{
			var items = new Dictionary<string, DataSetTemplate>();

			// Employees
			items.Add("Employees", new DataSetTemplate
			{
				DataSource = new DataSource
				{
					Name = "NorthwindEmployees",
					ConnectionProperties = {
						DataProvider = "SQLITE",
						ConnectString = "Data Source=Northwind.sqlite",
					}
				},
				DataSet = new DataSet
				{
					Name = "Employees",
					Query = {
						CommandText = "SELECT Id, FirstName, LastName, Title from Employee",
						DataSourceName = "NorthwindEmployees"
					},
					Fields = {
						new Field {
							Name = "Id",
							DataField = "Id",
						},
						new Field {
							Name = "FirstName",
							DataField = "FirstName",
						},
						new Field {
							Name = "LastName",
							DataField = "LastName",
						},
						new Field {
							Name = "Title",
							DataField = "Title",
						}
					}
				}
			});

			// Invoices
			items.Add("Invoices", new DataSetTemplate
			{
				DataSource = new DataSource
				{
					Name = "NWIND",
					ConnectionProperties = {
						DataProvider = "ODATA",
						ConnectString = "Url=https://services.odata.org/V4/Northwind/Northwind.svc",
					}
				},
				DataSet = new DataSet
				{
					Name = "Invoices",
					Query = {
						CommandText = "SELECT * FROM Invoices",
						DataSourceName = "NWIND"
					},
					Fields = {
						new Field {
							Name = "ShipName",
							DataField = "ShipName"
						},
						new Field {
							Name = "ShipAddress",
							DataField = "ShipAddress"
						},
						new Field {
							Name = "ShipCity",
							DataField = "ShipCity"
						},
						new Field {
							Name = "ShipRegion",
							DataField = "ShipRegion"
						},
						new Field {
							Name = "ShipPostalCode",
							DataField = "ShipPostalCode"
						},
						new Field {
							Name = "ShipCountry",
							DataField = "ShipCountry"
						},
						new Field {
							Name = "CustomerID",
							DataField = "CustomerID"
						},
						new Field {
							Name = "CustomerName",
							DataField = "CustomerName"
						},
						new Field {
							Name = "Address",
							DataField = "Address"
						},
						new Field {
							Name = "City",
							DataField = "City"
						},
						new Field {
							Name = "Region",
							DataField = "Region"
						},
						new Field {
							Name = "PostalCode",
							DataField = "PostalCode"
						},
						new Field {
							Name = "Country",
							DataField = "Country"
						},
						new Field {
							Name = "Salesperson",
							DataField = "Salesperson"
						},
						new Field {
							Name = "OrderID",
							DataField = "OrderID"
						},
						new Field {
							Name = "OrderDate",
							DataField = "OrderDate"
						},
						new Field {
							Name = "RequiredDate",
							DataField = "RequiredDate"
						},
						new Field {
							Name = "ShippedDate",
							DataField = "ShippedDate"
						},
						new Field {
							Name = "ShipperName",
							DataField = "ShipperName"
						},
						new Field {
							Name = "ProductID",
							DataField = "ProductID"
						},
						new Field {
							Name = "ProductName",
							DataField = "ProductName"
						},
						new Field {
							Name = "UnitPrice",
							DataField = "UnitPrice"
						},
						new Field {
							Name = "Quantity",
							DataField = "Quantity"
						},
						new Field {
							Name = "Discount",
							DataField = "Discount"
						},
						new Field {
							Name = "ExtendedPrice",
							DataField = "ExtendedPrice"
						},
						new Field {
							Name = "Freight",
							DataField = "Freight"
						}
					}
				}
			});

			Items = items;
		}
	}
}