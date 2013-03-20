<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="ValidationExample.aspx.vb" Inherits="WebFormsBootstrap.Web.ValidationExample" %>

<% 
    Bundles.Reference("resources/bootstrap/less/bootstrap.less")
    Bundles.Reference("resources/less")
    Bundles.Reference("resources/bootstrap/js")
%>
<!DOCTYPE html>

<html>
<head runat="server">
    <title>Bootstrap Example with Validation</title>
    <%= Bundles.RenderStylesheets()%>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div id="divErrorMessages" class="alert alert-error" runat="server" Visible="False" enableviewstate="False">
                <button type="button" class="close" data-dismiss="alert">&times;</button>
                <ul class="unstyled">
                    <asp:Repeater ID="rpErrorMessages" runat="server" ItemType="WebFormsBootstrap.Web.Common.Validation.FormError" EnableViewState="False">
                        <ItemTemplate>
                            <li><label for="<%# Item.Control.ClientID%>"><%# Item.ErrorMessage%></label></li>
                        </ItemTemplate>
                    </asp:Repeater>
                </ul>
            </div>
            <div class="form-horizontal">
                <div class="row">
                    <div class="span9">
                        <fieldset>
                            <legend>Legend</legend>
                            <bootstrap:ControlGroup ID="cgFirstName" Label="Name" runat="server">
                                <asp:TextBox ID="txtFirstName" CssClass="span3" placeholder="First" runat="server"></asp:TextBox>
                                <asp:TextBox ID="txtLastName" CssClass="span3" placeholder="Last" runat="server"></asp:TextBox>
                            </bootstrap:ControlGroup>
                            <bootstrap:ControlGroup ID="cgAge" Label="Age" runat="server">
                                <asp:TextBox ID="txtAge" CssClass="input-mini" runat="server"></asp:TextBox>
                            </bootstrap:ControlGroup>
                            <bootstrap:ControlGroup ID="cgDateRange" Label="Date" runat="server">
                                <asp:TextBox ID="txtStartDate" CssClass="span2" placeholder="mm/dd/yy" runat="server"></asp:TextBox>
                                <label>to</label>
                                <asp:TextBox ID="txtEndDate" CssClass="span2" placeholder="mm/dd/yy" runat="server"></asp:TextBox>
                            </bootstrap:ControlGroup>
                            <bootstrap:ControlGroup ID="cgTitle" Label="Title" runat="server">
                                <asp:TextBox ID="txtTitle" CssClass="span2" runat="server"></asp:TextBox>                                
                            </bootstrap:ControlGroup>
                            <bootstrap:ControlGroup ID="cgRequired" Label="Title Required" runat="server">
                                <asp:CheckBox ID="chkTitleRequired" runat="server" />
                            </bootstrap:ControlGroup>
                        </fieldset>
                        <div class="form-actions">
                            <button id="btnValidate" runat="server" class="btn btn-primary" onserverclick="btnValidate_Click"><i class="icon-search"></i> Validate</button>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
<script src="//ajax.googleapis.com/ajax/libs/jquery/1.9.1/jquery.min.js"></script>
<%= Bundles.RenderScripts()%>
</html>
