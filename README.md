WebFormsBootstrap
=================

ASP.NET Web Forms bootstrap and validation helpers

        txtAge.Validate("Age").Required().IsInteger().ApplyRule(AddressOf IsNotOld, "Too old")
        txtFirstName.Validate("First name").Required().Length(7)
        txtLastName.Validate("Last name").Required().Length(5)
        txtStartDate.Validate("Start date").Required().IsDate()
        txtEndDate.Validate("End date").IsDate()
