Imports Cassette
Imports Cassette.Scripts
Imports Cassette.Stylesheets

Namespace App_Start
    Public Class CassetteBundleConfiguration
        Implements IConfiguration(Of BundleCollection)

        Public Sub Configure(bundles As BundleCollection) Implements IConfiguration(Of BundleCollection).Configure
            bundles.Add(Of StylesheetBundle)("resources/bootstrap/less/bootstrap.less")
            bundles.Add(Of StylesheetBundle)("resources/less")
            bundles.Add(Of ScriptBundle)("resources/bootstrap/js")
        End Sub
    End Class
End Namespace