<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TReports.aspx.cs" Inherits="Tracking_System.TReports" %>

<!DOCTYPE html>

<script src="Scripts/jquery.js" type="text/javascript"></script>
<script src="Scripts/jquery.maskedinput.js" type="text/javascript"></script>


<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <script>
        jQuery(function ($) {
            $("#TextBox1").mask("99/99/9999", { placeholder: " " });
            $("#TextBox2").mask("99/99/9999", { placeholder: " " });
        });

    </script>

    <style type="text/css">

        body
        {
        background-image:url('Images/26.jpg');
        }
        .auto-style1
        {
        }
        .auto-style3
        {
            width: 106px;
        }
        .auto-style4
        {
            width: 153px;
        }
        .auto-style5
        {
            color: #CC0066;
            text-align: center;
            font-size: 40pt;
            font-family: Cambria, Cochin, Georgia, Times, "Times New Roman", serif;
        }
        .auto-style6
        {
            width: 97px;
        }
        .auto-style7
        {
            width: 97px;
            text-align: left;
            font-size: medium;
            font-family: Cambria, Cochin, Georgia, Times, "Times New Roman", serif;
            font-weight: 700;
            color: #003399;
        }
        .auto-style8
        {
            color: #999999;
            font-family: Cambria, Cochin, Georgia, Times, "Times New Roman", serif;
        }
        .auto-style9
        {
            width: 335px;
        }
        .auto-style12
        {
            width: 256px;
            height: 256px;
        }
        .auto-style13
        {
            width: 51px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:LinkButton ID="logoff" runat="server" OnClick="logoff_Click" style="float:right">Logout</asp:LinkButton>
        <br />
        <h1 class="auto-style5">Detailed Report</h1>
        <br />
        <br />
    
        <table style="width:100%;">
            <tr>
                <td class="auto-style13" rowspan="5">
                    <img alt="" class="auto-style12" src="Images/Report.png" /></td>
                <td class="auto-style7">From Date</td>
                <td class="auto-style9">
                    <asp:TextBox ID="TextBox1" runat="server" Width="165px"></asp:TextBox>
                    <span class="auto-style8">&nbsp;&nbsp;&nbsp; ex : mm/dd/yyyy</span></td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style7">To Date</td>
                <td class="auto-style9">
                    <asp:TextBox ID="TextBox2" runat="server" Width="165px"></asp:TextBox>
                    <span class="auto-style8">&nbsp;&nbsp;&nbsp; ex : mm/dd/yyyy</span></td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
               <%-- <asp:CustomValidator ID="CustomValidator1" OnServerValidate="ValidateDuration"
    ErrorMessage="Dates are too far apart" runat="server" />--%>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style9">
                    &nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style9">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Report" Width="89px" />
                   <asp:Button ID="btnClear" runat="server"  Text="Clear" OnClick="btnClear_Click" Width="73px"/>
                    <asp:Button ID="btnCancel" runat="server"  Text="Cancel" OnClick="btnCancel_Click" Width="75px"/>
                </td>
                <td class="auto-style3">
                    &nbsp;</td>
            </tr>
            <tr>
               
                <td class="auto-style6">
                    &nbsp;</td>
                <td class="auto-style9"><asp:Label ID="lblError" runat="server"></asp:Label>
                    &nbsp;</td>
            </tr>
            </table>
        <p>
        </p>
        <table style="width:100%;">
            <tr>
                <td class="auto-style4">
                    &nbsp;</td>
                <td class="auto-style1">
                    <asp:GridView ID="GridView1" runat="server" style="font-family: Cambria, Cochin, Georgia, Times, 'Times New Roman', serif">
                    </asp:GridView>
                   
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
