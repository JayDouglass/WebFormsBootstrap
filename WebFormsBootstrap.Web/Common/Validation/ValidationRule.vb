Namespace Common.Validation
    Public MustInherit Class ValidationRule
        Protected validator As FluentValidator
        Protected control As Control

        Public Sub New(validator As FluentValidator)
            Me.validator = validator
            control = validator.Control
        End Sub

        Protected Function GetControlValue() As String
            If TypeOf control Is WebControls.TextBox Then Return DirectCast(control, WebControls.TextBox).Text
            If TypeOf control Is DropDownList Then Return DirectCast(control, DropDownList).SelectedValue
            If TypeOf control Is RadioButtonList Then Return DirectCast(control, RadioButtonList).SelectedValue

            Throw New InvalidOperationException("Unhandled control type")
        End Function

        Public MustOverride Function Validate() As Boolean
    End Class
End NameSpace