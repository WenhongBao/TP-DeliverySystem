<%@ Page Language="C#" AutoEventWireup="true" CodeFile="comfirm.aspx.cs" Inherits="comfirm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 156px;
            height: 26px;
            position: absolute;
            left: 51px;
            top: 67px;
        }
        .auto-style2 {
            width: 62px;
            height: 21px;
            position: absolute;
            left: 583px;
            top: 310px;
        }
        .auto-style3 {
            width: 62px;
            height: 21px;
            position: absolute;
            left: 430px;
            top: 310px;
        }
    </style>
</head>
<body style="background-image:url(img/BG.jpg); background-repeat:repeat-x; ">
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblComfirmText" runat="server" style="top: 209px; left: 329px; position: absolute; height: 16px; width: 498px" Text="Label"></asp:Label>
        <asp:Button ID="btnNo" runat="server" CssClass="auto-style2" Text="No" OnClick="btnNo_Click1" />
        <asp:Button ID="btnYes" runat="server" CssClass="auto-style3" OnClick="btnYes_Click" Text="Yes" />
        <asp:Button ID="btnGoToUpdate" runat="server" CssClass="auto-style1" Text="&lt;-Update Your Parcel" OnClick="btnGoToUpdate_Click" />
    </form>
</body>
</html>
