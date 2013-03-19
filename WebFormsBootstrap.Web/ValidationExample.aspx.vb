Imports WebFormsBootstrap.Web.Common.Validation

Public Class ValidationExample
    Inherits BasePage

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnValidate_Click()
        txtAge.Validate().Required("Enter the age").IsInteger("Please enter a valid age")
        txtFirstName.Validate().Required("Enter the first name").Length("first name", 7)
        txtLastName.Validate().Required("Enter the last name").Length("last name", 5)
        txtStartDate.Validate().Required("Enter the start date").IsDate("Enter a valid start date")
        txtEndDate.Validate().IsDate("Enter a valid end date")
    End Sub

    Private Sub Page_PreRender(sender As Object, e As EventArgs) Handles Me.PreRender
        If Not FormState.IsValid Then
            divErrorMessages.Visible = True
            rpErrorMessages.DataSource = FormState.Errors
            rpErrorMessages.DataBind()
        End If
    End Sub
End Class