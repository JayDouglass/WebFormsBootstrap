Namespace Common.Validation
    Public Class FormState
        Property Errors() As List(Of FormError)

        Public Shared ReadOnly Property Current() As FormState
            Get
                Dim value = TryCast(HttpContext.Current.Items("FormState"), FormState)
                If value Is Nothing Then
                    value = New FormState()
                    HttpContext.Current.Items("FormState") = value
                End If
                Return value
            End Get
        End Property

        ReadOnly Property IsValid() As Boolean
            Get
                Return Errors.Count = 0
            End Get
        End Property
        Public Sub New()
            Errors = New List(Of FormError)()
        End Sub
    End Class
End NameSpace