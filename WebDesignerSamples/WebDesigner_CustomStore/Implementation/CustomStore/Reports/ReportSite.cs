using System;
using System.ComponentModel;

using GrapeCity.ActiveReports;


namespace WebDesignerCustomStore.Implementation.CustomStore.Reports
{
	internal class ReportSite : ISite
	{
		private readonly ResourceLocator _resourceLocator;

		public ReportSite(ResourceLocator resourceLocator) =>
			_resourceLocator = resourceLocator;

		public object GetService(Type serviceType) =>
			serviceType == typeof(ResourceLocator) ? _resourceLocator : null;

		public IComponent Component => null;
		public IContainer Container => null;
		public bool DesignMode => false;
		public string Name { get; set; }
	}
}
