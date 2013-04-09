Option Strict On
Public Class TempDataExample
    Inherits BasePage

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If TempData("message") IsNot Nothing Then
            litMessage.Text = DirectCast(TempData("message"), String)            
        End If

        Dim messages = TempData("messages")
    End Sub

    Protected Sub btnDoIt_Click(sender As Object, e As EventArgs)
        TempData("message") = "It works"
        Dim messages = New List(Of String)
        messages.Add("First message")
        TempData("messages") = messages

        Response.Redirect("~/TempDataExample.aspx", False) ' Must include False for TempData to work
    End Sub

    Protected Sub btnDoNothing_Click(sender As Object, e As EventArgs)

    End Sub
End Class