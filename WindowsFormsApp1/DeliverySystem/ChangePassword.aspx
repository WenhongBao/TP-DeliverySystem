<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ChangePassword.aspx.cs" Inherits="DeliverySystem.ChangePassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body style="background-image:url(img/BG.jpg); background-repeat:repeat-x; ">
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" style="top: 179px; left: 398px; position: absolute; height: 16px; width: 126px; right: 540px" Text="Account Number:"></asp:Label>
            <asp:TextBox ID="tbxAccountNumber" runat="server" style="top: 174px; left: 537px; position: absolute; height: 19px; width: 148px"></asp:TextBox>
            <asp:ChangePassword ID="ChangePassword1" runat="server" style="top: 205px; left: 294px; position: absolute; height: 132px; width: 478px">
            </asp:ChangePassword>
        </div>
    </form>
</body>
</html>
