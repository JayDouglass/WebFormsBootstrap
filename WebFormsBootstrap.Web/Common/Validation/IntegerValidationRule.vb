Namespace Common.Validation
    Public Class IntegerValidationRule
        Inherits ValidationRule
        Property ErrorMessage() As String

        Public Sub New(validator As FluentValidator, Optional errorMessage As String = Nothing)
            MyBase.New(validator)
            Me.ErrorMessage = If(errorMessage, "Enter a valid " & validator.ControlName)
        End Sub

        Public Overrides Function Validate() As Boolean
            Dim value As Integer
            If Not Integer.TryParse(GetControlValue(), value) Then
                validator.SetControlInvalid(ErrorMessage)
                Return False
            End If
            Return True
        End Function
    End Class
End Namespace