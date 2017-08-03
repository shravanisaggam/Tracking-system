<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Tracking_System.TLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    
    <title>PTS - Login Form</title>
    <style type="text/css">

        body
        {
        background-image:url('Images/13.jpg');
        }
        .auto-style3
        {
            color: #CC0000;
            font-family: Cambria, Cochin, Georgia, Times, "Times New Roman", serif;
            font-size: large;
            font-weight: 700;
        }
        .auto-style5
        {
        }
        .auto-style7
        {
            width: 67px;
        }
        .auto-style9
        {
            text-align: left;
            width: 379px;
        }
        .auto-style10
        {
            width: 379px;
        }
        .auto-style11
        {
            width: 9px;
        }
        .auto-style12
        {
            width: 565px;
        }
        .auto-style8
        {
            color: #3333CC;
            text-align: center;
            font-family: Cambria, Cochin, Georgia, Times, "Times New Roman", serif;
            width: 261px;
            margin-left: 114px;
        }
        .auto-style13
        {
            color: #CC0000;
            font-family: Cambria, Cochin, Georgia, Times, "Times New Roman", serif;
            font-size: large;
            font-weight: 700;
            width: 157px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
    <div >
    
        <table style="width:100%;">
            <tr>
                <td class="auto-style12" rowspan="14">
                    <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/Admin.png" style="text-align: center; margin-left: 108px; margin-top: 109px;" Width="348px" />
                </td>
                <td class="auto-style3" colspan="4">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3" colspan="4">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3" colspan="4">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3" colspan="4">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3" colspan="4">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3" colspan="4">
        <h1 class="auto-style8">User Login</h1>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style13">&nbsp;</td>
                <td class="auto-style10">
                    &nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style13">&nbsp;</td>
                <td class="auto-style10">
                    &nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style13">User Name</td>
                <td class="auto-style10">
                    <asp:TextBox ID="TextBox1" runat="server" Width="165px"></asp:TextBox>
                </td>
                <td class="auto-style7"></td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style13">Password</td>
                <td class="auto-style10">
                    <asp:TextBox ID="TextBox2" runat="server" TextMode="Password" Width="165px"></asp:TextBox>
                </td>
                <td class="auto-style7"></td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style13">&nbsp;</td>
                <td class="auto-style10">
                    &nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style13">&nbsp;</td>
                <td class="auto-style9">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Login" Width="80px" />
                    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Clear" Width="75px" />
                   <%-- <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Cancel" Width="69px" />--%>
                </td>
                <td class="auto-style7">
                    &nbsp;</td>
                <td class="auto-style11">
                    </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style13">&nbsp;</td>
                <td class="auto-style9">
                    &nbsp;</td>
                <td class="auto-style7">
                    &nbsp;</td>
                <td class="auto-style11">
                    </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style13">&nbsp;</td>
                <td class="auto-style5" colspan="3">
                    <asp:Label ID="Label1" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>

