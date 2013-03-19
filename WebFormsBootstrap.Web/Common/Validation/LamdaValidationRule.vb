Namespace Common.Validation

    Public Class LambdaValidationRule
        Inherits ValidationRule
        Property ErrorMessage() As String
        Dim predicate As Func(Of Boolean)

        Public Sub New(validator As FluentValidator, predicate As Func(Of Boolean), errorMessage As String)
            MyBase.New(validator)
            Me.ErrorMessage = errorMessage
            Me.predicate = predicate
        End Sub

        Public Overrides Function Validate() As Boolean
            Dim result = predicate()
            If result = False Then
                validator.SetControlInvalid(ErrorMessage)
            End If
            Return result
        End Function
    End Class
End Namespace