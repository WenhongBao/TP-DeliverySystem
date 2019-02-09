<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TrackAParcel.aspx.cs" Inherits="TrackAParcel" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            top: 96px;
            left: 138px;
            position: absolute;
            height: 16px;
            width: 183px;
            bottom: 442px;
        }
        .auto-style2 {
            top: 93px;
            left: 328px;
            position: absolute;
            height: 19px;
            width: 148px;
        }
        .auto-style3 {
            top: 91px;
            left: 518px;
            position: absolute;
            height: 27px;
            width: 131px;
        }
        .auto-style5 {
            top: 406px;
            left: 135px;
            position: absolute;
            height: 16px;
            width: 423px;
        }
        .auto-style6 {
            top: 399px;
            left: 1181px;
            position: absolute;
            height: 21px;
            width: 97px;
        }
        .auto-style7 {
            top: 96px;
            left: 964px;
            position: absolute;
            height: 21px;
            width: 130px;
        }
        .auto-style8 {
            width: 425px;
            height: 16px;
            position: absolute;
            left: 768px;
            top: 63px;
        }
        .auto-style9 {
            width: 1146px;
            height: 234px;
            position: absolute;
            left: 135px;
            top: 142px;
        }
        .auto-style10 {
            width: 148px;
            height: 19px;
            position: absolute;
            left: 766px;
            top: 93px;
        }
    </style>
</head>
<body style="background-image:url(img/BG.jpg); background-repeat:repeat-x; ">
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblInputOrderNumber" runat="server" Text="Destination Postcode:" CssClass="auto-style1"></asp:Label>
            <asp:ListBox ID="lbxOrderInfor" runat="server" CssClass="auto-style9"></asp:ListBox>
            <asp:Button ID="btnTrackYourParcel" runat="server" style="margin-bottom: 0px" Text="Track your parcel" OnClick="btnTrackYourParcel_Click" CssClass="auto-style3" />
        </div>
        <asp:TextBox ID="tbxDestinationPostcode" runat="server" CssClass="auto-style2"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" CssClass="auto-style5"></asp:Label>
        <p>
            &nbsp;</p>
        <asp:Button ID="btnGotoUpdate" runat="server" Text="Update the Order" OnClick="btnGotoUpdate_Click" CssClass="auto-style7" />
        <asp:Button ID="btnGotoQuickQuote" runat="server" Text="Quick Quote" OnClick="btnGotoQuickQuote_Click" CssClass="auto-style6" />
        <asp:TextBox ID="tbxOrderNo" runat="server" CssClass="auto-style10"></asp:TextBox>
        <asp:Button ID="btnGotoMainPage" runat="server" style="top: 39px; left: 56px; position: absolute; height: 21px; width: 94px" Text="&lt;- Main Page" OnClick="btnGotoMainPage_Click" />
        <asp:Label ID="Label1" runat="server" CssClass="auto-style8" Text="Input an OrderNo for Update"></asp:Label>
    </form>
</body>
</html>
