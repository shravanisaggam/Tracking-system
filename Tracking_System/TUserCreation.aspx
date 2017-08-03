<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TUserCreation.aspx.cs" Inherits="Tracking_System.TUserCreation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <style type="text/css">

        body
        {
        background-image:url('Images/11.jpg');
        }
        .auto-style3
        {
            width: 413px;
        }
        .auto-style6
        {
            text-align: center;
            color: #993333;
            font-size: 40pt;
            font-family: Cambria, Cochin, Georgia, Times, "Times New Roman", serif;
        }
        .auto-style7
        {
            width: 192px;
            text-align: center;
        }
        .auto-style9
        {
            text-align: center;
        }
        .auto-style10
        {
            width: 110px;
            text-align: left;
            font-family: Cambria, Cochin, Georgia, Times, "Times New Roman", serif;
            font-weight: 700;
        }
        .auto-style11
        {
            width: 271px;
            text-align: center;
        }
        .auto-style13
        {
            width: 87px;
            text-align: center;
        }
        .auto-style15
        {
            width: 311px;
            text-align: right;
        }
        .auto-style17
        {
            width: 74px;
            text-align: center;
        }
        .auto-style18
        {
            text-align: center;
            width: 8px;
        }
        .auto-style19
        {
            width: 213px;
            text-align: right;
        }
        .auto-style20
        {
            width: 273px;
            height: 263px;
            margin-left: 22px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:LinkButton ID="logoff" runat="server" OnClick="logoff_Click" style="float:right">Logout</asp:LinkButton>
        <h1 class="auto-style6">User Registration</h1>
        <br />
        <br />
    
        <table style="width:100%;">
            <tr>
                <td class="auto-style11"  font-size: x-large; font-weight: bolder; color: #000000" rowspan="9">
                    <img alt="" class="auto-style20" src="Images/usercreate.png" /></td>
                <td class="auto-style9" colspan="2"  font-size: x-large; font-weight: bolder; color: #000000">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style10">Employee ID</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBox1" runat="server" Width="185px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style10">Employee Name</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBox2" runat="server" Width="185px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style10">Password</td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtPswd" runat="server" Width="185px" TextMode="Password"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style10">&nbsp;</td>
                <td class="auto-style3">
                    <asp:Label ID="Label2" runat="server" Font-Italic="True" ForeColor="#999999" Text="*Password must contain atleast one special character"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style10">&nbsp;Job Category</td>
                <td class="auto-style3">
                    <asp:DropDownList ID="ddlJobCategory" runat="server" Height="24px" style="margin-left: 0px" Width="185px">
                        <%--<asp:ListItem>Admin</asp:ListItem>
                        <asp:ListItem>Agent</asp:ListItem>
                        <asp:ListItem>Supervisor</asp:ListItem>
                        <asp:ListItem>SME</asp:ListItem>--%>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style10">Email ID</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBox3" runat="server" Width="185px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style10">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style10">&nbsp;</td>
                <td class="auto-style3">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add Record" Width="118px" />
                    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Clear" Width="92px" />
                    <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
                </td>
            </tr>
            <tr>
                <td class="auto-style11">&nbsp;</td>
                <td class="auto-style10">&nbsp;</td>
                <td class="auto-style3">
                    &nbsp;</td>
            </tr>
            </table>
        <table style="width:100%;">
            <tr>
                <td class="auto-style13">&nbsp;</td>
                <td class="auto-style18">&nbsp;</td>
                <td class="auto-style19">
                    <asp:Label ID="Label3" runat="server"></asp:Label>
                </td>
                <td class="auto-style7">
                    &nbsp;</td>
            </tr>
        </table>
        <table style="width:100%;">
            <tr>
                <td class="auto-style13">&nbsp;</td>
                <td class="auto-style17">&nbsp;</td>
                <td class="auto-style15">
                    <asp:Label ID="Label1" runat="server" ForeColor="Black" style="text-align: left"></asp:Label>
                </td>
                <td class="auto-style7">
                    &nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>

