Imports WebFormsBootstrap.Web.Common.Validation

Public Class BasePage
    Inherits Page

    ReadOnly Property FormState() As FormState
        Get
            Return FormState.Current
        End Get
    End Property
End Class