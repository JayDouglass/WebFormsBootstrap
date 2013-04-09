Imports System.Web.Mvc
Imports WebFormsBootstrap.Web.Common.Validation

Public Class BasePage
    Inherits Page

    ReadOnly Property FormState() As FormState
        Get
            Return FormState.Current
        End Get
    End Property

    ReadOnly Property TempData() As TempDataDictionary
        Get
            Return Common.TempData.Current
        End Get
    End Property
End Class