<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TProblemLogin.aspx.cs" Inherits="Tracking_System.TProblemLogin" %>

<!DOCTYPE html>

<%--<script src="jquery.js" type="text/javascript"></script>
<script src="jquery.maskedinput.js" type="text/javascript"></script>--%>
<script src="Scripts/jquery.js" type="text/javascript"></script>
<script src="Scripts/jquery.maskedinput.js" type="text/javascript"></script>



<html xmlns="http://www.w3.org/1999/xhtml">

<head id="Head1" runat="server">
    <title></title>
 
    <script>
        jQuery(function ($) {
            $("#txtWorkStationNo").mask("999-999", { placeholder: " " });
        });

    </script>
    <style type="text/css">

         body
        {
        background-image:url('Images/11.jpg');
        }

        .auto-style2
        {
            width: 410px;
            text-align: center;
        }
        .auto-style3
        {
            width: 386px;
        }
        .auto-style4
        {
            text-align: left;
        }
        .auto-style5
        {
            text-align: left;
            width: 36px;
        }
        .auto-style6
        {
            width: 149px;
        }
        .auto-style7
        {
            text-align: left;
            width: 91px;
        }
        .auto-style8
        {
            width: 103px;
            text-align: center;
        }
        .auto-style9
        {
            width: 32px;
        }
        .auto-style10
        {
            font-family: Cambria, Cochin, Georgia, Times, "Times New Roman", serif;
        }
        .auto-style11
        {
            width: 185px;
            height: 166px;
            margin-left: 193px;
        }
        .auto-style12
        {
            font-family: Cambria, Cochin, Georgia, Times, "Times New Roman", serif;
            font-weight: bold;
            font-size: 40pt;
            color: #336600;
        }
        .auto-style13
        {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div class="auto-style13">
        <asp:LinkButton ID="logoff" runat="server" OnClick="logoff_Click" style="float:right">Logout</asp:LinkButton>
        <br />
        <br />
            <span class="auto-style12">Problem Login Screen</span><br />
        </div>
   <table align="center">
       <tr>

           <td class="auto-style5">&nbsp;</td>

           <td class="auto-style4">&nbsp;</td>
           <td class="auto-style2">&nbsp;</td>

           <td colspan="2" rowspan="5">
               <img alt="" class="auto-style11" src="Images/Mail.png" /></td>

       </tr>
       <tr>

           <td class="auto-style5">&nbsp;</td>

           <td class="auto-style4">&nbsp;</td>
           <td class="auto-style2">&nbsp;</td>

       </tr>
       <tr>

           <td class="auto-style5">&nbsp;</td>

           <td class="auto-style4">&nbsp;</td>
           <td class="auto-style2">&nbsp;</td>

       </tr>
       <tr>

           <td class="auto-style5">&nbsp;</td>

           <td class="auto-style4"><asp:Label  runat="server" Text="Problem Category"  ID="lblProblemCategory" CssClass="auto-style10"></asp:Label></td>
           <td class="auto-style2"><asp:DropDownList ID="ddlPCategory" runat="server" Height="22px" Width="165px">
               <asp:ListItem Value="0">Network Issues</asp:ListItem>
               <asp:ListItem Value="1">PC Issues</asp:ListItem>
               <asp:ListItem Value="2">Keyboard Issues</asp:ListItem>
               </asp:DropDownList></td>

       </tr>
       <tr>

           <td class="auto-style5">&nbsp;</td>

           <td class="auto-style4"><asp:Label  runat="server" Text="Problem Severity" ID="lblPSiviority" CssClass="auto-style10"></asp:Label></td>
           <td class="auto-style2"><asp:DropDownList ID="ddlPSiviority" runat="server" Height="26px" Width="165px">
               <asp:ListItem Value="0">Low</asp:ListItem>
               <asp:ListItem Value="1">Medium</asp:ListItem>
               <asp:ListItem Value="2">Critical</asp:ListItem>
               <asp:ListItem Value="3">High</asp:ListItem>
               </asp:DropDownList></td>

       </tr>
       <tr>

           <td class="auto-style5">&nbsp;</td>

           <td class="auto-style4"><asp:Label  runat="server" Text="Problem Description" ID="Label1" CssClass="auto-style10"></asp:Label></td>
           <td class="auto-style2"><asp:TextBox ID="txtPDescription" TextMode="MultiLine" runat="server" MaxLength="1000" Width="162px" style="margin-left: 2px"></asp:TextBox></td>

       </tr>
       
        <tr>

           <td class="auto-style5">&nbsp;</td>

           <td class="auto-style4"><asp:Label  runat="server" Text="Supervisor ID" ID="Label2" CssClass="auto-style10"></asp:Label></td>
           <td class="auto-style2"><asp:DropDownList ID="ddlSvID" runat="server" OnSelectedIndexChanged="ddlSvID_SelectedIndexChanged" Width="165px" AutoPostBack="True" Height="22px" ><asp:ListItem Text="Select"></asp:ListItem></asp:DropDownList></td>
           <td class="auto-style6"><asp:Label  runat="server" Text="Supervisor Name" ID="Label3" CssClass="auto-style10"></asp:Label></td>
           <td class="auto-style3"><asp:TextBox ID="txtSvName"  runat="server" ReadOnly="True" Height="16px" Width="165px"></asp:TextBox></td>

       </tr>

        <tr>

           <td class="auto-style5">&nbsp;</td>

           <td class="auto-style4"><asp:Label  runat="server" Text="Agent ID" ID="Label7" CssClass="auto-style10"></asp:Label></td>
           <td class="auto-style2"><asp:DropDownList ID="ddlAgName" runat="server" OnSelectedIndexChanged="ddlAgName_SelectedIndexChanged" Width="165px" AutoPostBack="True" Height="22px" ><asp:ListItem Text="Select"></asp:ListItem></asp:DropDownList></td>
           <td class="auto-style6"><asp:Label  runat="server" Text="Agent Name" ID="Label8" CssClass="auto-style10"></asp:Label></td>
           <td class="auto-style3"><asp:TextBox ID="txtAgName"  runat="server" ReadOnly="True" Width="165px"></asp:TextBox></td>

       </tr>

        <tr>

           <td class="auto-style5">&nbsp;</td>

           <td class="auto-style4"><asp:Label  runat="server" Text="WorkStation Number" ID="Label4" CssClass="auto-style10"></asp:Label></td>
           <td class="auto-style2"><asp:TextBox ID="txtWorkStationNo"  runat="server" Height="16px" Width="155px" style="margin-left: 1px"></asp:TextBox></td>
           

       </tr>
       <tr>

           <td class="auto-style5">&nbsp;</td>

           <td class="auto-style4"><asp:Label  runat="server" Text="Assigned To" ID="Label5" CssClass="auto-style10"></asp:Label></td>
           <td class="auto-style2"><asp:DropDownList ID="ddlSme" runat="server" OnSelectedIndexChanged="ddlSme_SelectedIndexChanged" Width="165px" AutoPostBack="True" Height="22px" ><asp:ListItem Text="Select"></asp:ListItem></asp:DropDownList></td>
           <td class="auto-style6"><asp:Label  runat="server" Text="SME Name" ID="Label6" CssClass="auto-style10"></asp:Label></td>
           <td class="auto-style3"><asp:TextBox ID="txtSmeName"  runat="server" ReadOnly="True" Width="165px"></asp:TextBox></td>

       </tr>
       <tr>

           <td class="auto-style5">&nbsp;</td>

           <td class="auto-style4">&nbsp;</td>
           <td class="auto-style2">&nbsp;</td>
           <td class="auto-style6">&nbsp;</td>
           <td class="auto-style3">&nbsp;</td>

       </tr>
       <tr>

           <td class="auto-style5"></td>

           <td class="auto-style4"></td>
           <td class="auto-style2"><%--<asp:Button ID="btnNotification" runat="server"  Text="Send Notification" OnClick="btnNotification_Click" Width="104px"/>--%></td><br />
           <td class="auto-style6"></td><br />
            <td class="auto-style3">&nbsp;</td>
       </tr>

   </table>
        <table align="center">
       <tr>

           <td class="auto-style7"><asp:Button ID="btnCreateSr" runat="server"  Text="Create SR" OnClick="btnCreateSr_Click" Width="72px" style="text-align: right"/></td>

           <td class="auto-style4">&nbsp;</td>
           <td class="auto-style8"><asp:Button ID="btnClear" runat="server"  Text="Clear" OnClick="btnClear_Click" Width="73px"/></td>
           <td class="auto-style9">&nbsp;</td>
            <td class="auto-style3"><asp:Button ID="btnCancel" runat="server"  Text="Cancel" OnClick="btnCancel_Click" Width="75px" style="margin-left: 0px"/></td>
       </tr>

       <tr>

           <td class="auto-style7"><asp:Label ID="lblStatus" runat="server"></asp:Label></td>

           <td class="auto-style4">&nbsp;</td>
           <td class="auto-style8">&nbsp;</td>
           <td class="auto-style9">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
       </tr>

   </table>
        
            </div>
   
    </form>
    </body>
</html>