<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Update.aspx.cs" Inherits="DeliverySystem.Update" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body style="background-image:url(img/BG.jpg); background-repeat:repeat-x; ">
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnSubmit" runat="server" style="top: 364px; left: 452px; position: absolute; height: 21px; width: 62px" Text="Submit" OnClick="btnSubmit_Click" />
            <asp:Button ID="btnCancelTheOrder" runat="server" style="top: 365px; left: 849px; position: absolute; height: 21px; width: 140px" Text="Cancel the order" OnClick="btnCancelTheOrder_Click" />
            <asp:Label ID="lblNewDestinationPostcode" runat="server" style="top: 210px; left: 188px; position: absolute; height: 16px; width: 203px" Text="New destination postcode:"></asp:Label>
            <asp:Label ID="lblAttention" runat="server" style="top: 113px; left: 190px; position: absolute; height: 16px; width: 484px" Text="Attention: You can update the destination postcode but maybe new and additional costs will be incurred."></asp:Label>
            <asp:TextBox ID="tbxNewDestinationPostcode" runat="server" style="top: 207px; left: 443px; position: absolute; height: 19px; width: 148px"></asp:TextBox>
            <asp:Label ID="lblError" runat="server" style="top: 302px; left: 191px; position: absolute; height: 16px; width: 322px; right: 525px" Text="[Error]"></asp:Label>
        </div>
        <asp:Button ID="btnGotoTrackAParcel" runat="server" style="top: 52px; left: 52px; position: absolute; height: 21px; width: 130px" Text="&lt;- Track a Parcel" OnClick="btnGotoTrackAParcel_Click" />
    </form>
</body>
</html>
