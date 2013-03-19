Imports WebFormsBootstrap.Web.Controls.Bootstrap

Namespace Common.Validation
    Public Class FluentValidator
        Property Control() As Control
        Property FormState() As FormState
        Property ControlName() As String

        Dim _stopValidating As Boolean
        ReadOnly Property StopValidating() As Boolean
            Get
                Return _stopValidating
            End Get
        End Property

        Public Sub New(control As Control, Optional controlName As String = Nothing)
            FormState = FormState.Current
            Me.Control = control
            Me.ControlName = controlName
        End Sub

        Public Sub ApplyRule(rule As ValidationRule)
            If Not StopValidating Then
                Dim result = rule.Validate()
                If result = False Then
                    _stopValidating = True ' stop validating on first error
                End If
            End If
        End Sub

        Public Sub ApplyRule(predicate As Func(Of Boolean), errorMessage As String)
            ApplyRule(New LambdaValidationRule(Me, predicate, errorMessage))
        End Sub

        Public Sub SetControlInvalid(errorMessage As String)
            FormState.Errors.Add(New FormError(errorMessage, Control))
            SetErrorStyle()
        End Sub

        Sub SetErrorStyle()
            Dim controlGroup As Control = Control.Parent
            ' traverse up control tree looking for the first ControlGroup
            Do While controlGroup IsNot Nothing AndAlso Not TypeOf controlGroup Is ControlGroup
                controlGroup = controlGroup.Parent
            Loop

            If controlGroup IsNot Nothing AndAlso TypeOf controlGroup Is ControlGroup Then
                DirectCast(controlGroup, ControlGroup).ValidationStatus = ValidationState.Error
            End If
        End Sub
    End Class
End Namespace