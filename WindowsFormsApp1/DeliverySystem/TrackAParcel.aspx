<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TrackAParcel.aspx.cs" Inherits="DeliverySystem.TrackAParcel" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblInputOrderNumber" runat="server" style="top: 157px; left: 200px; position: absolute; height: 16px; width: 112px; bottom: 381px" Text="Order Number:"></asp:Label>
            <asp:ListBox ID="lbxOrderInfor" runat="server" style="top: 114px; left: 555px; position: absolute; height: 214px; width: 202px"></asp:ListBox>
            <asp:Button ID="btnTrackYourParcel" runat="server" style="top: 241px; left: 348px; position: absolute; height: 36px; width: 131px; margin-bottom: 0px" Text="Track your parcel" />
        </div>
        <asp:TextBox ID="tbxOrderNumber" runat="server" style="top: 157px; left: 345px; position: absolute; height: 19px; width: 148px"></asp:TextBox>
        <p>
            &nbsp;</p>
        <asp:Button ID="btnGotoUpdate" runat="server" style="top: 306px; left: 799px; position: absolute; height: 21px; width: 130px" Text="Update the Order" />
        <asp:Button ID="btnGotoQuickQuote" runat="server" style="top: 116px; left: 799px; position: absolute; height: 21px; width: 97px" Text="Quick Quote" />
        <asp:Button ID="btnGotoMainPage" runat="server" style="top: 39px; left: 56px; position: absolute; height: 21px; width: 94px" Text="&lt;- Main Page" />
    </form>
</body>
</html>
