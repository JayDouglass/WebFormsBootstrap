Imports System.Runtime.CompilerServices

Namespace Common.Validation
    Public Module ValidationExtensions
        <Extension()>
        Public Function Validate(control As Control) As FluentValidator
            Return New FluentValidator(control)
        End Function

        <Extension()>
        Public Function Required(validator As FluentValidator, message As String) As FluentValidator
            validator.ApplyRule(New RequiredValidationRule(validator, message))
            Return validator
        End Function

        <Extension()>
        Public Function IsDate(validator As FluentValidator, message As String) As FluentValidator
            validator.ApplyRule(New DateValidationRule(validator, message))
            Return validator
        End Function

        <Extension()>
        Public Function IsDecimal(validator As FluentValidator, message As String) As FluentValidator
            validator.ApplyRule(New DecimalValidationRule(validator, message))
            Return validator
        End Function

        <Extension()>
        Public Function Length(validator As FluentValidator, name As String, max As Integer, Optional min As Integer = 0) As FluentValidator
            validator.ApplyRule(New LengthValidationRule(validator, name, max, min))
            Return validator
        End Function

        <Extension()>
        Public Function IsInteger(validator As FluentValidator, message As String) As FluentValidator
            validator.ApplyRule(New IntegerValidationRule(validator, message))
            Return validator
        End Function
    End Module
End Namespace