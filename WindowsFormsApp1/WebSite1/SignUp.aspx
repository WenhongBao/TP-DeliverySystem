<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SignUp.aspx.cs" Inherits="SignUp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 163px;
            height: 16px;
            position: absolute;
            left: 13px;
            top: 200px;
        }
        .auto-style2 {
            width: 157px;
            height: 16px;
            position: absolute;
            left: 12px;
            top: 226px;
        }
        .auto-style3 {
            width: 163px;
            height: 16px;
            position: absolute;
            left: 13px;
            top: 252px;
        }
        .auto-style4 {
            width: 156px;
            height: 16px;
            position: absolute;
            left: 14px;
            top: 282px;
        }
        .auto-style5 {
            width: 148px;
            height: 19px;
            position: absolute;
            left: 196px;
            top: 198px;
        }
        .auto-style6 {
            width: 148px;
            height: 19px;
            position: absolute;
            left: 196px;
            top: 225px;
        }
        .auto-style7 {
            width: 148px;
            height: 19px;
            position: absolute;
            left: 196px;
            top: 252px;
        }
        .auto-style8 {
            width: 65px;
            height: 19px;
            position: absolute;
            left: 199px;
            top: 313px;
        }
        .auto-style9 {
            width: 148px;
            height: 19px;
            position: absolute;
            left: 195px;
            top: 279px;
            right: 517px;
        }
        .auto-style10 {
            width: 152px;
            height: 16px;
            position: absolute;
            left: 14px;
            top: 313px;
        }
    </style>
</head>
<body style="background-image:url(img/BG.jpg); background-repeat:repeat-x; ">
    <form id="form1" runat="server">
            <div>
            <br />
                <asp:Label ID="lblFirstName" runat="server" CssClass="auto-style1" Text="First Name"></asp:Label>
                <asp:Label ID="lblLastName" runat="server" CssClass="auto-style2" Text="Last Name"></asp:Label>
                <asp:Label ID="lblPostcode" runat="server" CssClass="auto-style3" Text="Defule Postcode"></asp:Label>
                <asp:Label ID="lblTelephone" runat="server" CssClass="auto-style4" Text="Telephone Number"></asp:Label>
                <asp:Label ID="lblTitle" runat="server" CssClass="auto-style10" Text="Title"></asp:Label>
            <h1>Account Sign Up</h1>
                <table style="width: 100%;">
                    <tr>
                        <td style="width: 182px">
            <asp:Label ID="lblEMail" runat="server" Text="E Mail Address"></asp:Label>
                        </td>
                        <td><asp:TextBox ID="txtEMail" runat="server" width="318px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 182px">
            <asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label>
                        </td>
                        <td><asp:TextBox ID="txtPassword1" runat="server" TextMode="Password" width="318px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 182px">
            <asp:Label ID="lblConfirm" runat="server" Text="Confirm Password"></asp:Label>
                        </td>
                        <td><asp:TextBox ID="txtPassword2" runat="server" TextMode="Password" width="318px"></asp:TextBox>
                        </td>
                    </tr>
                </table>
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <asp:Label ID="lblError" runat="server"></asp:Label>
                <br />
                <br />
        </div>
        <asp:Button ID="btnSignUp" runat="server" Text="Sign-up" OnClick="btnSignUp_Click" />
&nbsp;<asp:Button ID="btnDone" runat="server" Text="Done" OnClick="btnDone_Click" />
&nbsp;<asp:Button ID="btnReSend" runat="server" Text="Re-set Password" OnClick="btnReSend_Click" />
&nbsp;<asp:Button ID="btnView" runat="server" OnClick="btnView_Click" Text="View Email" />
            <asp:TextBox ID="txtFirstName" runat="server" CssClass="auto-style5" Width="318px"></asp:TextBox>
            <asp:TextBox ID="txtLastName" runat="server" CssClass="auto-style6" Width="318px"></asp:TextBox>
            <asp:TextBox ID="txtPostcode" runat="server" CssClass="auto-style7" Width="318px"></asp:TextBox>
            <asp:TextBox ID="txtTelephone" runat="server" CssClass="auto-style9" Width="318px"></asp:TextBox>
            <asp:DropDownList ID="ddlTitle" runat="server" CssClass="auto-style8">
                <asp:ListItem Selected="True">Mr</asp:ListItem>
                <asp:ListItem>Miss</asp:ListItem>
                <asp:ListItem>Mrs</asp:ListItem>
            </asp:DropDownList>
    </form>
</body>
</html>
