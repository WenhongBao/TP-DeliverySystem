<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GotQuickQuote.aspx.cs" Inherits="DeliverySystem.GotQuickQuote" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblResultOfQuote" runat="server" style="top: 240px; left: 475px; position: absolute; height: 16px; width: 40px" Text="Label"></asp:Label>
        </div>
        <asp:Button ID="btnGotoIndex" runat="server" OnClick="btnGotoIndex_Click" style="top: 299px; left: 233px; position: absolute; height: 36px; width: 105px" Text="Main Page" />
        <asp:Button ID="btnGoToQuickQuote" runat="server" OnClick="btnGoToQuickQuote_Click" style="top: 299px; left: 419px; position: absolute; height: 37px; width: 158px; right: 461px;" Text="Continue Quick Quote" />
        <asp:Button ID="btnGotoTrackAParcel" runat="server" OnClick="btnGotoTrackAParcel_Click" style="top: 298px; left: 644px; position: absolute; height: 40px; width: 111px" Text="Track A Parcel" />
    </form>
</body>
</html>
