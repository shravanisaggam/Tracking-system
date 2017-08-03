<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2
        {
            height: 23px;
            width: 157px;
        }
        .auto-style3
        {
            width: 157px;
        }
        .auto-style4
        {
            height: 23px;
            width: 130px;
        }
        .auto-style5
        {
        }
        .auto-style6
        {
            height: 23px;
            width: 67px;
        }
        .auto-style7
        {
            width: 67px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div >
    
        <table style="width:100%;">
            <tr>
                <td class="auto-style2" style=" font-size: x-large; font-weight: bolder">User Login</td>
                <td class="auto-style4"></td>
                <td class="auto-style6"></td>
            </tr>
            <tr>
                <td class="auto-style3">UserName</td>
                <td class="auto-style5">
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style7">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">Password</td>
                <td class="auto-style5">
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style7">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style5">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Login" />
                </td>
                <td class="auto-style7">
                    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Clear" />
                </td>
                <td>
                    <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" style="height: 26px" Text="Cancel" />
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style5" colspan="3">
                    <asp:Label ID="Label1" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
