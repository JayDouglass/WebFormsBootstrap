Namespace Common.Validation
    Public Class FormError
        Property ErrorMessage() As String
        Property Control() As Control

        Public Sub New(errorMessage As String, control As Control)
            Me.ErrorMessage = errorMessage
            Me.Control = control
        End Sub
    End Class
End NameSpace