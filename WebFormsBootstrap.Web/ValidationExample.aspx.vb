Imports WebFormsBootstrap.Web.Common.Validation

Public Class ValidationExample
    Inherits BasePage

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnValidate_Click()
        txtFirstName.Validate("First name").Required().Length(7)
        txtLastName.Validate("Last name").Required().Length(5)
        txtAge.Validate("Age").IsInteger().WhenControlIsValid(txtFirstName).Required().ApplyRule(AddressOf IsNotOld, "Too old")
        txtStartDate.Validate("Start date").Required().IsDate()
        txtEndDate.Validate("End date").IsDate()
        txtTitle.Validate("Title").When(chkTitleRequired.Checked).Required()
    End Sub

    Function IsNotOld() As Boolean
        Dim age = Integer.Parse(txtAge.Text)
        Return age < 60
    End Function

    Private Sub Page_PreRender(sender As Object, e As EventArgs) Handles Me.PreRender
        If Not FormState.IsValid Then
            BootstrapInvalidControlGroupStyler.StyleInvalidControls(FormState.Errors)
            divErrorMessages.Visible = True
            rpErrorMessages.DataSource = FormState.Errors
            rpErrorMessages.DataBind()
        End If
    End Sub
End Class