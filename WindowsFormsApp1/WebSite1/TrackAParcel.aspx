<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TrackAParcel.aspx.cs" Inherits="TrackAParcel" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            top: 161px;
            left: 133px;
            position: absolute;
            height: 16px;
            width: 183px;
            bottom: 377px;
        }
    </style>
</head>
<body style="background-image:url(img/BG.jpg); background-repeat:repeat-x; ">
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblInputOrderNumber" runat="server" Text="Destination Postcode:" CssClass="auto-style1"></asp:Label>
            <asp:ListBox ID="lbxOrderInfor" runat="server" style="top: 114px; left: 555px; position: absolute; height: 214px; width: 245px"></asp:ListBox>
            <asp:Button ID="btnTrackYourParcel" runat="server" style="top: 241px; left: 348px; position: absolute; height: 36px; width: 131px; margin-bottom: 0px" Text="Track your parcel" OnClick="btnTrackYourParcel_Click" />
        </div>
        <asp:TextBox ID="tbxDestinationPostcode" runat="server" style="top: 157px; left: 345px; position: absolute; height: 19px; width: 148px"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" style="top: 299px; left: 202px; position: absolute; height: 16px; width: 326px" Text="[Error]"></asp:Label>
        <p>
            &nbsp;</p>
        <asp:Button ID="btnGotoUpdate" runat="server" style="top: 305px; left: 832px; position: absolute; height: 21px; width: 130px" Text="Update the Order" OnClick="btnGotoUpdate_Click" />
        <asp:Button ID="btnGotoQuickQuote" runat="server" style="top: 118px; left: 829px; position: absolute; height: 21px; width: 97px" Text="Quick Quote" OnClick="btnGotoQuickQuote_Click" />
        <asp:Button ID="btnGotoMainPage" runat="server" style="top: 39px; left: 56px; position: absolute; height: 21px; width: 94px" Text="&lt;- Main Page" OnClick="btnGotoMainPage_Click" />
    </form>
</body>
</html>
