Namespace Common.Validation
    Public Class DecimalValidationRule
        Inherits ValidationRule

        Property ErrorMessage() As String

        Public Sub New(validator As FluentValidator, errorMessage As String)
            MyBase.New(validator)
            Me.ErrorMessage = errorMessage
        End Sub

        Public Overrides Function Validate() As Boolean
            If String.IsNullOrEmpty(GetControlValue()) Then Return True
            Dim value As Decimal
            If Not Decimal.TryParse(GetControlValue(), value) Then
                validator.SetControlInvalid(ErrorMessage)
                Return False
            End If
            Return True
        End Function
    End Class
End NameSpace