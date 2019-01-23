<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="DeliverySystem.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            top: 169px;
            left: 388px;
            position: absolute;
            height: 133px;
            width: 280px;
            right: 370px;
            bottom: 252px;
        }
    </style>
</head>
<body style="background-image:url(img/BG.jpg); background-repeat:repeat-x; ">
    <form id="form1" runat="server">
        <div>
            <asp:Login ID="Login1" runat="server" CreateUserText="Sign Up" CreateUserUrl="~/SignUp.aspx" DestinationPageUrl="~/Secure/index.aspx" CssClass="auto-style1">
            </asp:Login>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="top: 73px; left: 73px; position: absolute; height: 21px; width: 134px" Text="&lt;- Back To Index" />
        </div>
        <asp:Button ID="btnForgetPassword" runat="server" OnClick="btnForgetPassword_Click" style="top: 201px; left: 699px; position: absolute; height: 21px; width: 122px" Text="Forget Password" />
        <p>
            &nbsp;</p>
        <asp:Button ID="btnChangePassword" runat="server" OnClick="btnChangePassword_Click" style="top: 231px; left: 701px; position: absolute; height: 21px; width: 119px" Text="Change Password" />
    </form>
</body>
</html>
