WebFormsBootstrap
=================

ASP.NET Web Forms bootstrap and validation helpers

        txtAge.Validate() _
            .Required("Enter the age") _
            .IsInteger("Please enter a valid age") _
            .ApplyRule(AddressOf IsNotOld, "Too old")
        txtFirstName.Validate().Required("Enter the first name").Length("first name", 7)
        txtLastName.Validate().Required("Enter the last name").Length("last name", 5)
        txtStartDate.Validate().Required("Enter the start date").IsDate("Enter a valid start date")
        txtEndDate.Validate().IsDate("Enter a valid end date")
