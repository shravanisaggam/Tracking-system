<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TSMEScreen.aspx.cs" Inherits="Tracking_System.TSMEScreen" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <style type="text/css">

        body
        {
        background-image:url('Images/14.jpg');
        }
        .auto-style1
        {
            width: 184px;
        }
        .auto-style2
        {
            width: 351px;
        }
        .auto-style3
        {
            text-align: center;
            color: #000066;
            font-weight: bold;
            font-size: 40pt;
            font-family: Cambria, Cochin, Georgia, Times, "Times New Roman", serif;
        }
        .auto-style4
        {
            width: 201px;
            height: 186px;
            margin-left: 85px;
        }
        .auto-style5
        {
            font-family: Cambria, Cochin, Georgia, Times, "Times New Roman", serif;
            color: #990099;
        }
        .auto-style6
        {
            font-family: Cambria, Cochin, Georgia, Times, "Times New Roman", serif;
            color: #660033;
            font-weight: bold;
        }
        .auto-style7
        {
            color: #FF3300;
            font-weight: bold;
        }
        .auto-style8
        {
            width: 184px;
            font-weight: bold;
        }
        .auto-style9
        {
            font-family: Cambria, Cochin, Georgia, Times, "Times New Roman", serif;
            color: #660033;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:LinkButton ID="logoff" runat="server" OnClick="logoff_Click" style="float:right">Logout</asp:LinkButton>
        <br />
        <h1 class="auto-style3">SME SCREEN</h1>
        <br />
&nbsp;&nbsp;&nbsp;
   <table align="center" style="width: 970px">
       <tr>

           <td class="auto-style7"><asp:Label  runat="server" Text="Log Number"  ID="lblProblemCategory" CssClass="auto-style6"></asp:Label></td>
           <td class="auto-style2"><asp:DropDownList ID="ddlLogs" runat="server" AutoPostBack="True"  OnSelectedIndexChanged="ddlLogs_SelectedIndexChanged" Height="28px" Width="174px">
            
               </asp:DropDownList></td>
           <td class="auto-style8"><asp:Label  runat="server" Text="SR Date"  ID="Label2" CssClass="auto-style9"></asp:Label></td>
           <td><asp:TextBox ID="txtSrDate" runat="server" ReadOnly="True" Width="169px"></asp:TextBox></td>

       </tr>
       <tr>

           <td class="auto-style7"><asp:Label  runat="server" Text="Problem Severity " ID="lblPSiviority" CssClass="auto-style6"></asp:Label></td>
           <td class="auto-style2"><asp:TextBox ID="txtPbSeviority" runat="server" ReadOnly="True" Width="169px"></asp:TextBox></td>
           <td class="auto-style8"><asp:Label  runat="server" Text="Problem Category" ID="Label3" CssClass="auto-style9"></asp:Label></td>
           <td><asp:TextBox ID="txtPbCategory" runat="server" ReadOnly="True" Width="169px"></asp:TextBox></td>

       </tr>
       <tr>

           <td class="auto-style7"><asp:Label  runat="server" Text="Current Status" ID="Label1" CssClass="auto-style6"></asp:Label></td>
           <td class="auto-style2"><asp:TextBox ID="txtCurrentStatus"  runat="server" Width="169px"></asp:TextBox></td>
           <td class="auto-style8"><asp:Label  runat="server" Text="Proposed Status" ID="Label7" CssClass="auto-style9"></asp:Label></td>
           <td><asp:TextBox ID="txtProposedStatus"  runat="server" Width="169px"></asp:TextBox></td>

       </tr>
       
        <tr>

           <td class="auto-style7"><asp:Label  runat="server" Text="Problem Description" ID="Label4" CssClass="auto-style6"></asp:Label></td>
           <td class="auto-style2"><asp:TextBox ID="txtPbDescription" TextMode="MultiLine"  runat="server" ReadOnly="True" Width="261px"></asp:TextBox></td>

            <td>
                <asp:Label ID="Label9" runat="server" ForeColor="#666666" Text="*Proposed status must be filled when it is final update" CssClass="auto-style5"></asp:Label>
            </td>

       </tr>
       <tr>

           <td class="auto-style7"><asp:Label  runat="server" Text="Supervisor Id" ID="Label5" CssClass="auto-style6"></asp:Label></td>
           <td class="auto-style2"><asp:TextBox ID="txtSupervisorid" runat="server" Width="169px" ReadOnly="True"></asp:TextBox></td>
           <td colspan="2" rowspan="6">
               <img alt="" class="auto-style4" src="Images/SMe.png" /></td>
          <%-- <td class="auto-style1"><asp:Label  runat="server" Text="SupervisorName" ID="Label6"></asp:Label></td>
           <td><asp:TextBox ID="txtSupervisorName"  runat="server"></asp:TextBox></td>--%>

       </tr>
       <tr>

           <td class="auto-style7"><asp:Label  runat="server" Text="Resolution" ID="Label8" CssClass="auto-style6"></asp:Label></td>
           <td class="auto-style2"><asp:TextBox ID="txtResoution" TextMode="MultiLine"  runat="server" Width="261px"></asp:TextBox></td>

       </tr>

       <tr>

           <td class="auto-style7"><asp:Label  runat="server" Text="SME Id" ID="Label6" CssClass="auto-style6"></asp:Label></td>
           <td class="auto-style2"><asp:TextBox ID="txtSME" runat="server" Width="169px" ReadOnly="True"></asp:TextBox></td>
          <%-- <td class="auto-style1"><asp:Label  runat="server" Text="SupervisorName" ID="Label6"></asp:Label></td>
           <td><asp:TextBox ID="txtSupervisorName"  runat="server"></asp:TextBox></td>--%>

       </tr>

       <tr>

           <td>&nbsp;</td>
           <td class="auto-style2">&nbsp;</td>

       </tr>
       <tr>

           <td>&nbsp;</td>
            <td class="auto-style2"><asp:Button ID="btnUpdateSr" runat="server"  Text="Update SR" OnClick="btnUpdateSr_Click" style="text-align: center" Width="105px"/>
            <asp:Button ID="btnClear" runat="server"  Text="Clear" OnClick="btnClear_Click" Width="85px"/>
                    <asp:Button ID="btnCancel" runat="server"  Text="Cancel" OnClick="btnCancel_Click" Width="82px"/>
            <tr>
           <td class="auto-style1">&nbsp;</td>
           <td><asp:Label ID="lblStatus" runat="server"></asp:Label></td>
       </tr>
   </table>
    </div>
    </form>
  
       
</body>
</html>