﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="QuickQuote.aspx.cs" Inherits="DeliverySystem.QuickQuote" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnGetAQuote" runat="server" Text="Get a quote" style="top: 409px; left: 464px; position: absolute; height: 36px; width: 124px" OnClick="btnGetAQuote_Click" />
            <asp:DropDownList ID="ddlDestinationCountry" runat="server" style="top: 93px; left: 463px; position: absolute; height: 19px; width: 136px">
                <asp:ListItem Selected="True" Value="UnitedKingdom">United Kingdom</asp:ListItem>
                <asp:ListItem>China</asp:ListItem>
                <asp:ListItem Value="UnitedStates">United States</asp:ListItem>
                <asp:ListItem>Africa</asp:ListItem>
            </asp:DropDownList>
            <asp:DropDownList ID="ddlParcelSize" runat="server" style="top: 304px; left: 458px; position: absolute; height: 19px; width: 203px">
                <asp:ListItem Selected="True" Value="XS">XS 20*20*20/23*33*5 &lt;2kg</asp:ListItem>
                <asp:ListItem>S 35*35*35 &lt;5kg</asp:ListItem>
                <asp:ListItem Value="M">M 45*45*45 &lt;10kg</asp:ListItem>
                <asp:ListItem Value="L">L 60*60*60 &lt;15kg</asp:ListItem>
                <asp:ListItem Value="XL">XL 70*70*70/120*50*50/140*35*35 &lt;20kg</asp:ListItem>
                <asp:ListItem Value="XXL">XXL 80*80*80 &lt;25kg</asp:ListItem>
            </asp:DropDownList>
            <asp:TextBox ID="tbxCollectionPostcode" runat="server" style="top: 159px; left: 461px; position: absolute; height: 19px; width: 148px"></asp:TextBox>
        </div>
        <asp:TextBox ID="tbxDeliveryPostcode" runat="server" style="top: 225px; left: 460px; position: absolute; height: 19px; width: 148px"></asp:TextBox>
        <asp:Label ID="lblDestinationCountry" runat="server" style="top: 96px; left: 273px; position: absolute; height: 16px; width: 169px" Text="Destination Country:"></asp:Label>
        <asp:Label ID="lblCollectionPostcode" runat="server" style="top: 155px; left: 273px; position: absolute; height: 16px; width: 167px" Text="Collection Postcode:"></asp:Label>
        <asp:Label ID="lblDeliveryPostcode" runat="server" style="top: 228px; left: 287px; position: absolute; height: 16px; width: 158px" Text="Delivery Postcode:"></asp:Label>
        <asp:Label ID="lblParcelSize" runat="server" style="top: 305px; left: 333px; position: absolute; height: 16px; width: 113px" Text="Parcel Size:"></asp:Label>
        <asp:Button ID="btnGotoTrackAParcel" runat="server" style="top: 89px; left: 769px; position: absolute; height: 21px; width: 115px" Text="Track a parcel" OnClick="btnGotoTrackAParcel_Click" />
        <asp:Button ID="btnGotoMainPage" runat="server" Height="21px" style="top: 34px; left: 34px; position: absolute; width: 95px" Text="&lt;- Main Page" OnClick="btnGotoMainPage_Click" />
        <asp:Label ID="lblError" runat="server" style="top: 306px; left: 769px; position: absolute; height: 16px; width: 40px" Text="[Error]"></asp:Label>
    </form>
</body>
</html>
