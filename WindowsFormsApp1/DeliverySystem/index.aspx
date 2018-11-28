<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="DeliverySystem.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body style="position: relative; top: 0px; left: 0px; height: 292px">
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnQuickQuote" runat="server" style="top: 110px; left: 475px; position: absolute; height: 41px; width: 136px" Text="Quick Quote" />
            <asp:Button ID="btnTrackAParcel" runat="server" style="top: 181px; left: 476px; position: absolute; height: 44px; width: 134px" Text="Track A Parcel" />
        </div>
        <p>
            <asp:Button ID="btnLogin" runat="server" style="top: 25px; left: 805px; position: absolute; height: 21px; width: 62px" Text="Login" />
        </p>
        <p>
            <asp:Button ID="btnRegister" runat="server" style="top: 25px; left: 942px; position: absolute; height: 21px; width: 62px" Text="Register" />
        </p>
    </form>
</body>
</html>
