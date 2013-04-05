Namespace Common.Validation
    Public Class PhoneValidationRule
        Inherits ValidationRule
        Property ErrorMessage() As String

        Public Sub New(validator As FluentValidator, Optional errorMessage As String = Nothing)
            MyBase.New(validator)
            Me.ErrorMessage = If(errorMessage, "Enter a valid " & validator.ControlName)
        End Sub

        Public Overrides Function Validate() As Boolean
            If String.IsNullOrEmpty(GetControlValue()) Then Return True
            If Not NumbersOnly(GetControlValue()).Length = 10 Then
                validator.SetControlInvalid(ErrorMessage)
                Return False
            End If
            Return True
        End Function

        Private Function NumbersOnly(str As String) As String
            Dim arr As Char() = str.ToCharArray()

            arr = Array.FindAll(Of Char)(arr, (Function(c) (Char.IsDigit(c))))
            str = New String(arr)
            Return str
        End Function
    End Class
End Namespace