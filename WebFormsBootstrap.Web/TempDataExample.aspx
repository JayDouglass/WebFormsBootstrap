<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="TempDataExample.aspx.vb" Inherits="WebFormsBootstrap.Web.TempDataExample" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Literal ID="litMessage" runat="server" EnableViewState="False"></asp:Literal>
    <div>        
        <button runat="server" OnServerClick="btnDoIt_Click">Put something in TempData and redirect</button>
        <button runat="server" OnServerClick="btnDoNothing_Click">Postback, do nothing</button>
    </div>
    </form>
</body>
</html>
