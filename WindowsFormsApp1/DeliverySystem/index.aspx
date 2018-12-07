<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="DeliverySystem.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body style="position: relative; top: 0px; left: 0px; height: 292px; background-image:url(img/BG.jpg); background-repeat:repeat-x; ">
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnQuickQuote" runat="server" style="top: 167px; left: 474px; position: absolute; height: 41px; width: 136px" Text="Quick Quote" OnClick="btnQuickQuote_Click" />
            <asp:Button ID="btnTrackAParcel" runat="server" style="top: 272px; left: 474px; position: absolute; height: 44px; width: 134px" Text="Track A Parcel" OnClick="btnTrackAParcel_Click" />
        </div>
        <p>
            <asp:Button ID="btnLogin" runat="server" style="top: 25px; left: 805px; position: absolute; height: 21px; width: 62px" Text="Login" OnClick="btnLogin_Click" />
        </p>
        <p>
            <asp:Button ID="btnRegister" runat="server" style="top: 25px; left: 942px; position: absolute; height: 21px; width: 62px" Text="Register" OnClick="btnRegister_Click" />
        </p>
    </form>
</body>
</html>
