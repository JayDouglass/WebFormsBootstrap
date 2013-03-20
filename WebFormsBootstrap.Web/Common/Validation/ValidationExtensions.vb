Imports System.Runtime.CompilerServices

Namespace Common.Validation
    Public Module ValidationExtensions
        <Extension()>
        Public Function Validate(control As Control, Optional controlName As String = Nothing) As FluentValidator
            Return New FluentValidator(control, controlName)
        End Function

        <Extension()>
        Public Function [When](validator As FluentValidator, test As Boolean) As FluentValidator
            If Not test Then
                validator.StopValidating = True
            End If
            Return validator
        End Function

        <Extension()>
        Public Function [When](validator As FluentValidator, predicate As Func(Of Boolean)) As FluentValidator
            If Not predicate() Then
                validator.StopValidating = True
            End If
            Return validator
        End Function

        <Extension()>
        Public Function WhenControlIsValid(validator As FluentValidator, control As Control) As FluentValidator
            If FormState.Current.Errors.Any(Function(e) ReferenceEquals(e.Control, control)) Then
                validator.StopValidating = True
            End If
            Return validator
        End Function

        <Extension()>
        Public Function Required(validator As FluentValidator, Optional message As String = Nothing) As FluentValidator
            validator.ApplyRule(New RequiredValidationRule(validator, message))
            Return validator
        End Function

        <Extension()>
        Public Function IsDate(validator As FluentValidator, Optional message As String = Nothing) As FluentValidator
            validator.ApplyRule(New DateValidationRule(validator, message))
            Return validator
        End Function

        <Extension()>
        Public Function IsDecimal(validator As FluentValidator, message As String) As FluentValidator
            validator.ApplyRule(New DecimalValidationRule(validator, message))
            Return validator
        End Function

        <Extension()>
        Public Function Length(validator As FluentValidator, max As Integer, Optional min As Integer = 0) As FluentValidator
            validator.ApplyRule(New LengthValidationRule(validator, max, min))
            Return validator
        End Function

        <Extension()>
        Public Function IsInteger(validator As FluentValidator, Optional message As String = Nothing) As FluentValidator
            validator.ApplyRule(New IntegerValidationRule(validator, message))
            Return validator
        End Function
    End Module
End Namespace