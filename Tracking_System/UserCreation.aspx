<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UserCreation.aspx.cs" Inherits="UserCreation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2
        {
        }
        .auto-style3
        {
            width: 110px;
        }
        .auto-style4
        {
            width: 123px;
        }
        .auto-style5
        {
            width: 104px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table style="width:100%;">
            <tr>
                <td class="auto-style2" colspan="2" style="font-family: &quot;Lucida Sans&quot;, &quot;Lucida Sans Regular&quot;, &quot;Lucida Grande&quot;, &quot;Lucida Sans Unicode&quot;, Geneva, Verdana, sans-serif; font-size: x-large; font-weight: bolder; color: #000000">User Registration</td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">Employee id</td>
                <td class="auto-style5">
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">Employee name</td>
                <td class="auto-style5">
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">Job Category</td>
                <td class="auto-style5">
                    <asp:DropDownList ID="DropDownList1" runat="server">
                        <asp:ListItem>Supervisor</asp:ListItem>
                        <asp:ListItem>SME</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">Email id</td>
                <td class="auto-style5">
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style5">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add Record" />
                </td>
                <td class="auto-style3">
                    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" style="width: 46px" Text="Clear" />
                </td>
                <td>
                    <asp:Button ID="Button3" runat="server" Text="Cancel" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style5">
                    <asp:Label ID="Label1" runat="server"></asp:Label>
                </td>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
