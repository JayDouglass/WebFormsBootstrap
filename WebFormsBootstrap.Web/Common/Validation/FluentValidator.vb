Imports WebFormsBootstrap.Web.Controls.Bootstrap

Namespace Common.Validation
    Public Class FluentValidator
        Property Control() As Control
        Property FormState() As FormState
        Property ControlName() As String
        Property StopValidating() As Boolean

        Public Sub New(control As Control, Optional controlName As String = Nothing)
            FormState = FormState.Current
            Me.Control = control
            Me.ControlName = controlName
        End Sub

        Public Sub ApplyRule(rule As ValidationRule)
            If Not StopValidating Then
                Dim result = rule.Validate()
                If result = False Then
                    StopValidating = True ' stop validating on first error
                End If
            End If
        End Sub

        Public Sub ApplyRule(predicate As Func(Of Boolean), errorMessage As String)
            ApplyRule(New LambdaValidationRule(Me, predicate, errorMessage))
        End Sub

        Public Sub SetControlInvalid(errorMessage As String)
            FormState.Errors.Add(New FormError(errorMessage, Control))
        End Sub
    End Class
End Namespace