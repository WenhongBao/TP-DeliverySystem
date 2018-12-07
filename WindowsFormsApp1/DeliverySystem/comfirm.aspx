<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="comfirm.aspx.cs" Inherits="DeliverySystem.comfirm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body style="background-image:url(img/BG.jpg); background-repeat:repeat-x; ">
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblComfirmText" runat="server" style="top: 209px; left: 329px; position: absolute; height: 16px; width: 498px" Text="Label"></asp:Label>
        <asp:Button ID="btnYes" runat="server" style="top: 306px; left: 431px; position: absolute; height: 21px; width: 62px; right: 545px;" Text="Yes" OnClick="btnYes_Click" />
        <asp:Button ID="btnGotoUpdate" runat="server" OnClick="btnGotoUpdate_Click" style="top: 59px; left: 55px; position: absolute; height: 31px; width: 151px" Text="&lt;-Update Your Parcel" />
        <asp:Button ID="btnNo" runat="server" style="top: 306px; left: 595px; position: absolute; height: 21px; width: 62px" Text="No" OnClick="btnNo_Click" />
    </form>
</body>
</html>
