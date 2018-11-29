<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="comfirm.aspx.cs" Inherits="DeliverySystem.comfirm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblComfirmText" runat="server" style="top: 209px; left: 329px; position: absolute; height: 16px; width: 498px" Text="Label"></asp:Label>
        <asp:Button ID="btnYes" runat="server" style="top: 306px; left: 431px; position: absolute; height: 21px; width: 62px" Text="Yes" />
        <asp:Button ID="btnNo" runat="server" style="top: 306px; left: 595px; position: absolute; height: 21px; width: 62px" Text="No" />
    </form>
</body>
</html>
