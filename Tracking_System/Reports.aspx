<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Reports.aspx.cs" Inherits="Reports" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1
        {
        }
        .auto-style2
        {
            width: 128px;
        }
        .auto-style3
        {
            width: 106px;
        }
        .auto-style4
        {
            width: 120px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table style="width:100%;">
            <tr>
                <td class="auto-style4">From Date</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">To Date</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style2">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Report" />
                </td>
                <td class="auto-style3">
                    <asp:Button ID="Button2" runat="server" Text="Clear" />
                </td>
                <td>
                    <asp:Button ID="Button3" runat="server" Text="Cancel" />
                </td>
            </tr>
            <tr>
                <td class="auto-style1" colspan="4">
                    <asp:GridView ID="GridView1" runat="server">
                    </asp:GridView>
                   
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
