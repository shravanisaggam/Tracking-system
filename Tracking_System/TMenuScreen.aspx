<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TMenuScreen.aspx.cs" Inherits="Tracking_System.TMenuScreen" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Problem Tracking System - Menu </title>

    
    <style type="text/css">
        .auto-style1
        {
            text-align: left;
        }
        .auto-style2
        {
            color: #FF6600;
            text-align: center;
            font-size: xx-large;
            font-family: Cambria, Cochin, Georgia, Times, "Times New Roman", serif;
        }

         body
        {
        background-image:url('Images/11.jpg');
        }

        .auto-style3
        {
            width: 100%;
        }
        .auto-style4
        {
        }
        .auto-style7
        {
        }
        .auto-style8
        {
            width: 135px;
        }
        .auto-style9
        {
            width: 79px;
        }
        .auto-style10
        {
            font-family: Cambria, Cochin, Georgia, Times, "Times New Roman", serif;
            font-size: x-large;
        }
        .auto-style11
        {
            width: 135px;
            font-family: Cambria, Cochin, Georgia, Times, "Times New Roman", serif;
            font-size: x-large;
        }
        .auto-style12
        {
            color: #CC3300;
            text-align: center;
            font-size: 40pt;
            font-family: Cambria, Cochin, Georgia, Times, "Times New Roman", serif;
        }

    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="auto-style1">
        <table class="auto-style3">
            <tr>
                <td class="auto-style9">&nbsp;</td>
                <td class="auto-style8">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4" colspan="4">
        <h1 class="auto-style12">Admin Menu</h1>
                </td>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style9" rowspan="14">
                    <asp:Image ID="Image1" runat="server" Height="320px" ImageUrl="~/Images/3.png" style="margin-left: 90px" Width="326px" />
                </td>
                <td class="auto-style7" colspan="2">
        <asp:LinkButton ID="logoff" runat="server" OnClick="logoff_Click" style="float:right; font-family: Cambria, Cochin, Georgia, Times, 'Times New Roman', serif; font-size: large; margin-left: 2px; margin-bottom: 0px;" Height="23px" Width="93px">Logout</asp:LinkButton>
                </td>
                <td class="auto-style7">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style7" colspan="2">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style7" colspan="2">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style8">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style11">&nbsp;</td>
                <td class="auto-style10"> <a href="TProblemLogin.aspx">SR Screen</a>&nbsp;&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style11">&nbsp;</td>
                <td class="auto-style10">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style11">&nbsp;</td>
                <td class="auto-style10"> <a href="TSMEScreen.aspx">SME Screen</a>&nbsp;&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style11">&nbsp;</td>
                <td class="auto-style10">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style11">&nbsp;</td>
                <td><span class="auto-style10"><a href="TUserCreation.aspx">User Creation</a>&nbsp;&nbsp;</span></td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style11">&nbsp;</td>
                <td class="auto-style10">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style11">&nbsp;</td>
                <td><span class="auto-style10"><a href="TReports.aspx">Report Generation</a></span></td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style8">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style8">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style8">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <h1 class="auto-style2">&nbsp;</h1>
        <br />
       
    </div>
    </form>
</body>
</html>
