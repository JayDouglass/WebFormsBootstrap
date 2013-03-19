Imports HtmlTags
Imports System.IO
Imports System.Linq

Namespace Controls.Bootstrap
    ''' <summary>
    ''' Outputs boilerplate markup for bootstrap form control group
    ''' </summary>
    <ParseChildren(False)> _
    <PersistChildren(True)>
    Public Class ControlGroup
        Inherits WebControl
        Implements INamingContainer

        Property Label() As String
        Property HelpText() As String

        'Property ValidationStatus() As ValidationState
        '    Get
        '        Dim value = ViewState("ValidationStatus")
        '        Return If(value IsNot Nothing, DirectCast(value, ValidationState), ValidationState.None)
        '    End Get
        '    Set(value As ValidationState)
        '        ViewState("ValidationStatus") = value
        '    End Set
        'End Property
        Property ValidationStatus() As ValidationState

        Protected Overrides Sub Render(writer As HtmlTextWriter)
            Dim controlGroup = New HtmlTag("div").AddClass("control-group")
            controlGroup.AddClasses(CssClass)
            Dim firstWebControl = Me.Controls.OfType(Of WebControl).FirstOrDefault()
            controlGroup.Append(New HtmlTag("label").AddClass("control-label") _
                                    .Attr("for", If(firstWebControl IsNot Nothing, firstWebControl.ClientID, "")).Text(Label))

            If ValidationStatus <> ValidationState.None Then
                controlGroup.AddClass(ValidationStatus.ToString().ToLowerInvariant())
            End If

            Dim controls = New HtmlTag("div").AddClass("controls controls-row")
            controlGroup.Append(controls)

            Dim stringWriter As New StringWriter()
            Dim htmlTextWriter As New HtmlTextWriter(stringWriter)
            RenderContents(htmlTextWriter) ' just render contents instead of render, so that start and end tag are not output
            controls.AppendHtml(stringWriter.ToString())

            If Not String.IsNullOrEmpty(HelpText) Then controls.Append(New HtmlTag("span").AddClass("help-block").Text(HelpText))

            writer.Write(controlGroup.ToString())
        End Sub
    End Class
End Namespace