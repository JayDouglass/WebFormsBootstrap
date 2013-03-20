WebFormsBootstrap
=================

ASP.NET Web Forms bootstrap and validation helpers

        txtFirstName.Validate("First name").Required().Length(7)
        txtLastName.Validate("Last name").Required().Length(5)
        txtAge.Validate("Age").IsInteger().WhenControlIsValid(txtFirstName).Required().ApplyRule(AddressOf IsNotOld, "Too old")
        txtStartDate.Validate("Start date").Required().IsDate()
        txtEndDate.Validate("End date").IsDate()
        txtTitle.Validate("Title").When(chkTitleRequired.Checked).Required()
