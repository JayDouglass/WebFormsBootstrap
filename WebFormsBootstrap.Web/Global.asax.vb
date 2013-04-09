Imports System.Web.SessionState
Imports System.Web.Routing
Imports System.Web.Mvc
Imports WebFormsBootstrap.Web.Common

Public Class WebFormsBootstrapApplication
    Inherits System.Web.HttpApplication

    Sub Application_Start(ByVal sender As Object, ByVal e As EventArgs)
        ' Fires when the application is started
    End Sub

    Sub Session_Start(ByVal sender As Object, ByVal e As EventArgs)
        ' Fires when the session is started
    End Sub

    Sub Application_BeginRequest(ByVal sender As Object, ByVal e As EventArgs)
        ' Fires at the beginning of each request
    End Sub

    Sub Application_AuthenticateRequest(ByVal sender As Object, ByVal e As EventArgs)
        ' Fires upon attempting to authenticate the use
    End Sub

    Sub Application_Error(ByVal sender As Object, ByVal e As EventArgs)
        ' Fires when an error occurs
    End Sub

    Sub Session_End(ByVal sender As Object, ByVal e As EventArgs)
        ' Fires when the session ends
    End Sub

    Sub Application_End(ByVal sender As Object, ByVal e As EventArgs)
        ' Fires when the application ends
    End Sub

    Sub Application_AcquireRequestState()
        Dim tempDataDictionary = New TempDataDictionary()
        Dim tempDataProvider = New SessionStateTempDataProvider()
        Dim controllerContext = New ControllerContext(New HttpContextWrapper(HttpContext.Current), New RouteData(), New NullController())
        tempDataDictionary.Load(controllerContext, tempDataProvider)
        TempData.Current = tempDataDictionary
    End Sub

    Sub Application_PostRequestHandlerExecute()
        If Not HttpContext.Current.Session Is Nothing Then
            Dim tempDataProvider = New SessionStateTempDataProvider()
            Dim controllerContext = New ControllerContext(New HttpContextWrapper(HttpContext.Current), New RouteData(), New NullController())
            TempData.Current.Save(controllerContext, tempDataProvider)
        End If
    End Sub

End Class