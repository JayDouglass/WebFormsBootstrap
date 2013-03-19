Namespace Common.Validation
    Public Class LengthValidationRule
        Inherits ValidationRule

        Property Max() As Integer
        Property Min() As Integer

        Public Sub New(validator As FluentValidator, max As Integer, Optional min As Integer = 0)
            MyBase.New(validator)
            Me.Max = max
            Me.Min = min
        End Sub

        Public Overrides Function Validate() As Boolean
            Dim value = GetControlValue()
            If value.Length < 0 Then
                validator.SetControlInvalid(String.Format("{0} must be at least {1} characters", validator.ControlName, Min.ToString()))
                Return False
            End If
            If value.Length > Max Then
                validator.SetControlInvalid(String.Format("{0} must be no more than {1} characters", validator.ControlName, Max.ToString()))
                Return False
            End If
            Return True
        End Function
    End Class
End NameSpace