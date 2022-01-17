Imports System.IO
Imports GrapeCity.ActiveReports.Web

Public Class _Global
    Inherits System.Web.HttpApplication

    Protected Sub Application_Start(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.UseReporting(Sub(settings)
            settings.UseFileStore(New DirectoryInfo(Server.MapPath("~")))
            settings.UseCompression = True
        End Sub)
    End Sub

End Class