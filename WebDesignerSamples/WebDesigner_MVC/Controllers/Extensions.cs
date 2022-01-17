using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebDesigner_MVC.Controllers
{
	public static class ControllerHelpers
	{
		public static T GetServiceFromContext<T>(this HttpContextBase httpContext)
		{
			var context = httpContext.GetOwinContext();
			if (context == null) return default(T);
			return context.Get<T>(typeof(T).ToString());
		}
	}
}
