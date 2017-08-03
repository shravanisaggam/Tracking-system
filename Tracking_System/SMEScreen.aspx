<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SMEScreen.aspx.cs" Inherits="SMEScreen" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1
        {
            width: 103px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
   <table>
       <tr>

           <td><asp:Label  runat="server" Text="LogNumbers"  ID="lblProblemCategory"></asp:Label></td>
           <td><asp:DropDownList ID="ddlLogs" runat="server" AutoPostBack="True"  OnSelectedIndexChanged="ddlLogs_SelectedIndexChanged">
            
               </asp:DropDownList></td>
           <td class="auto-style1"><asp:Label  runat="server" Text="SRDate"  ID="Label2"></asp:Label></td>
           <td><asp:TextBox ID="txtSrDate" runat="server" ReadOnly="True"></asp:TextBox></td>

       </tr>
       <tr>

           <td><asp:Label  runat="server" Text="ProblemSeviority" ID="lblPSiviority"></asp:Label></td>
           <td><asp:TextBox ID="txtPbSeviority" runat="server" ReadOnly="True"></asp:TextBox></td>
           <td class="auto-style1"><asp:Label  runat="server" Text="ProblemCategory" ID="Label3"></asp:Label></td>
           <td><asp:TextBox ID="txtPbCategory" runat="server" ReadOnly="True"></asp:TextBox></td>

       </tr>
       <tr>

           <td><asp:Label  runat="server" Text="CurrrentStatus" ID="Label1"></asp:Label></td>
           <td><asp:TextBox ID="txtCurrentStatus"  runat="server"></asp:TextBox></td>
           <td class="auto-style1"><asp:Label  runat="server" Text="ProposedStatus" ID="Label7"></asp:Label></td>
           <td><asp:TextBox ID="txtProposedStatus"  runat="server"></asp:TextBox></td>

       </tr>
       
        <tr>

           <td><asp:Label  runat="server" Text="ProblemDscription" ID="Label4"></asp:Label></td>
           <td><asp:TextBox ID="txtPbDescription" TextMode="MultiLine"  runat="server" ReadOnly="True"></asp:TextBox></td>

       </tr>
       <tr>

           <td><asp:Label  runat="server" Text="SuprvisorId" ID="Label5"></asp:Label></td>
           <td><asp:TextBox ID="txtSupervisorid" runat="server" Width="164px" ReadOnly="True"></asp:TextBox></td>
           <td class="auto-style1"><asp:Label  runat="server" Text="SupervisorName" ID="Label6"></asp:Label></td>
           <td><asp:TextBox ID="txtSupervisorName"  runat="server"></asp:TextBox></td>

       </tr>
       <tr>

           <td><asp:Label  runat="server" Text="Resolution" ID="Label8"></asp:Label></td>
           <td><asp:TextBox ID="txtResoution" TextMode="MultiLine"  runat="server"></asp:TextBox></td>

       </tr>
       <tr>

           <td><asp:Button ID="btnUpdateSr" runat="server"  Text="UpdateSr" OnClick="btnUpdateSr_Click"/></td>
            <td><asp:Label ID="lblStatus" runat="server"></asp:Label></td>
           <td class="auto-style1">&nbsp;</td>
       </tr>

   </table>
    </div>
    </form>
  
       
</body>
</html>
