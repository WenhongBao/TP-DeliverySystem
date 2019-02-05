<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 40px;
            height: 16px;
            position: absolute;
            left: 66px;
            top: 22px;
        }
        .auto-style2 {
            top: 21px;
            left: 812px;
            position: absolute;
            height: 21px;
            width: 62px;
            margin-bottom: 4px;
        }
        .auto-style3 {
            height: 21px;
            position: absolute;
            top: 60px;
            right: 388px;
        }
        .auto-style4 {
            width: 62px;
            height: 21px;
            position: absolute;
            top: 21px;
            left: 908px;
        }
        .auto-style5 {
            height: 21px;
            position: absolute;
            top: 61px;
            left: 716px;
            margin-bottom: 1px;
        }
        .auto-style6 {
            top: 21px;
            left: 708px;
            position: absolute;
            height: 21px;
            width: 62px;
        }
    </style>
</head>
<body style="position: relative; top: 0px; left: 0px; height: 292px; background-image:url(img/BG.jpg); background-repeat:repeat-x; ">
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblHi" runat="server" CssClass="auto-style1" Text="Hi~"></asp:Label>
            <asp:Button ID="btnQuickQuote" runat="server" style="top: 167px; left: 474px; position: absolute; height: 41px; width: 136px" Text="Quick Quote" OnClick="btnQuickQuote_Click" />
            <asp:Button ID="btnTrackAParcel" runat="server" style="top: 272px; left: 474px; position: absolute; height: 44px; width: 134px" Text="Track A Parcel" OnClick="btnTrackAParcel_Click" />
        </div>
        <p>
            <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" CssClass="auto-style6" />
        </p>
        <p>
            <asp:Button ID="btnRegister" runat="server" Text="Register" OnClick="btnRegister_Click" CssClass="auto-style2" />
            <asp:Button ID="btnReSet" runat="server" CssClass="auto-style3" OnClick="btnReSet_Click" Text="Forgot Password" />
            <asp:Button ID="btnSignOut" runat="server" CssClass="auto-style4" OnClick="btnSignOut_Click" Text="Sign out" />
            <asp:Button ID="btnChangePassword" runat="server" CssClass="auto-style5" OnClick="btnChangePassword_Click" Text="Change Password" />
        </p>
    </form>
</body>
</html>
